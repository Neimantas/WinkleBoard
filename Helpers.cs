using MySql.Data.MySqlClient;
using System.Data;

namespace WinkleBoard
{
    public static class Helpers
    {
        public static string Removed(this string source, IEnumerable<char> chars)
        {
            return new String(source.Where(x => !chars.Contains(x)).ToArray());
        }

        public static List<string> MakeQuery(string input)
        {
            var queryList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                //Exception a. For start of the str.
                if (i == 0) queryList.Add("%" + input);
                var tempStr = input.Replace(input[i], '%');
                queryList.Add(tempStr);

                //Exception b. For end of the str.
                if (i == (input.Length - 1)) queryList.Add(input + "%");
            }

            return queryList;
        }

        public static string RemoveThese(string input, string remove)
        {
            foreach (char c in remove)
            {
                int found = input.IndexOf(c);
                if (found >= 0) input = input.Remove(found, 1);
            }
            return input;
        }

        public static List<string> ReadWordsFromDB(string input)
        {
            MySqlConnection connect = new MySqlConnection("SERVER=localhost; user id=sa; password=Qwerty11; database=dictionary");
            //Distinct removes same words, because for some reason duplicates do exist.
            MySqlCommand cmd = new MySqlCommand($"SELECT DISTINCT word FROM dictionary.entries WHERE word like '{input}'")
            {
                CommandType = CommandType.Text,
                Connection = connect
            };

            var wordList = new List<string>();

            try
            {
                connect.Open();

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    wordList.Add(dr.GetString("word"));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return wordList;
        }
    }
}