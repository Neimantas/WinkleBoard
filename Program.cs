// See https://aka.ms/new-console-template for more information
using System.Data;
using WinkleBoard;
using WinkleBoard.Search;

Console.WriteLine("Please input word for Word Corrector:");

//We tried to do it by hand, but meh.
var makePricing = new OperationPrice();
makePricing.FillCosts();
var checkPrice = OperationPrice.OpCost;
//Meh.

//1. Input text.
//var input = "aple";
var input = (Console.ReadLine() ?? string.Empty).ToUpper();
var queryList = Helpers.MakeQuery(input);
var foundWords = new List<string>();

//2. Search in the db possible result list with % wildcard
foreach (var item in queryList)
{
    foundWords.AddRange(Helpers.ReadWordsFromDB(item));
}

//Different runs can actually find same values, to battle this, we clean this way
//We could check if exist on creation of the list or better yet try to insert into dict.
var distinctFWords = foundWords.Select(x => x).Distinct();

//3. Jaro-Winkle words against the word provided
var ratedDictionary = new Dictionary<string, double>();

foreach (var item in distinctFWords)
{
    //var rez = JaroWinklerDistance.distance(input, item);
    var rez = DistanceCalc.JaroWinkler(input, item.ToUpper());
    ratedDictionary.Add(item, rez);
}

//Our work above is kinda complete, because 'Capple' will be offered as the best mathematical solution.
var ordered = ratedDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

Console.WriteLine("Your word (mathematically) probably is: " + ordered.FirstOrDefault().Key + ". With probability of:" + ordered.FirstOrDefault().Value);
//4. Run keyboard algo to find distance for extra characters provided with dictionary words. Best guess = ('apple' - 'aple') - KeyBoardDist
//Caple dist: 38.1
//Apple dist: 0;

var topTenW = ordered.Take(10);
var keyboardedDict = new Dictionary<string, double>();
foreach (var item in topTenW)
{
    //To upper, because our keyboard algo is in UPPER.
    var extraChars = Helpers.RemoveThese(item.Key.ToUpper(), input);
    var overAllDist = 0.0;

    foreach (var chars in extraChars)
    {
        var pos = item.Key.ToUpper().IndexOf(chars);
        //Sometimes new word can be longer/more than 1 characters added, so we need to set it's end to the input word.
        if (pos > input.Length - 1) pos = input.Length - 1;
        var toCheck = input[pos];
        overAllDist += KeyboardDistanceCalculator.CalculateDistance(chars, toCheck);
    }

    //5. Jaro-Winkle + KeyBoarDist = Best Overall Guess
    //The distance is too great to be handled in milimeters, so we make it smaller weight, to give more logical impact as weight.
    //TODO. There probably exist a smarter way to translate distance into Jaro-Winkle distance.
    var changeVal = item.Value - (overAllDist / 1000);
    keyboardedDict.Add(item.Key, changeVal);
}

//Final order of keyboarded Dict
var orderKeyDict = keyboardedDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine("Your word (maths + keyboard distance) probably is: " + orderKeyDict.FirstOrDefault().Key + ". With probability of:" + orderKeyDict.FirstOrDefault().Value);
Thread.Sleep(10000);

//So what is the diff? Let us take 2 words as an example: aple (Apple) and schol (School)
//This Algo returns Apple/Apple and Scholy/School
//Do what you will with this info :)