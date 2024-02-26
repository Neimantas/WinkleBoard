namespace WinkleBoard
{
    public class KeyboardDistanceCalculator
    {
        //This monster is based on this thread: https://codegolf.stackexchange.com/questions/233618/distances-between-keys-on-a-qwerty-keyboard
        private static int GetCharIndex(char c)
        {
            const string keys = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int index = keys.IndexOf(c);
            int row = index > 8 ? 1 : 0;
            row += index > 17 ? 1 : 0;
            return index - new[] { 0, 39, 73 }[row] / 4;
        }

        //TODO. L & P combo is broken, check later why.
        public static double CalculateDistance(char a, char b)
        {
            int y1, y2;
            int x1 = GetCharIndex(a);
            y1 = x1 > 8 ? 1 : 0;
            y1 += x1 > 17 ? 1 : 0;

            int x2 = GetCharIndex(b);
            y2 = x2 > 8 ? 1 : 0;
            y2 += x2 > 17 ? 1 : 0;
            //Euclidean distance between keys, in millimetres
            return Double.Hypot(x1 - x2, y1 - y2) * 19.05;
        }
    }
}