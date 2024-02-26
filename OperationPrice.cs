namespace WinkleBoard
{
    public class OperationPrice
    {
        public static List<KeyBoard> OpCost = new List<KeyBoard>();

        public class KeyBoard
        {
            private char v1;
            private char v2;
            private float v3;

            public KeyBoard(char v1, char v2, float v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;

                OpCost.Add(this);
            }
        }

        public void FillCosts()
        {
            if (OpCost.Count == 0)
            {
                new KeyBoard('q', 'a', 0.5f);
                new KeyBoard('q', 's', 0.3f);

                new KeyBoard('w', 'q', 0.5f);
                new KeyBoard('w', 'e', 0.5f);
                new KeyBoard('w', 's', 0.5f);
                new KeyBoard('w', 'a', 0.3f);
                new KeyBoard('w', 'd', 0.3f);

                new KeyBoard('e', 'w', 0.5f);
                new KeyBoard('e', 'r', 0.5f);
                new KeyBoard('e', 'd', 0.5f);
                new KeyBoard('e', 's', 0.3f);
                new KeyBoard('e', 'f', 0.3f);

                new KeyBoard('r', 'e', 0.5f);
                new KeyBoard('r', 't', 0.5f);
                new KeyBoard('r', 'f', 0.5f);
                new KeyBoard('r', 'd', 0.3f);
                new KeyBoard('r', 'g', 0.3f);

                new KeyBoard('t', 'r', 0.5f);
                new KeyBoard('t', 'y', 0.5f);
                new KeyBoard('t', 'g', 0.5f);
                new KeyBoard('t', 'f', 0.3f);
                new KeyBoard('t', 'h', 0.3f);

                new KeyBoard('y', 't', 0.5f);
                new KeyBoard('y', 'u', 0.5f);
                new KeyBoard('y', 'h', 0.5f);
                new KeyBoard('y', 'g', 0.3f);
                new KeyBoard('y', 'j', 0.3f);

                new KeyBoard('u', 'y', 0.5f);
                new KeyBoard('u', 'i', 0.5f);
                new KeyBoard('u', 'j', 0.5f);
                new KeyBoard('u', 'h', 0.3f);
                new KeyBoard('u', 'k', 0.3f);

                new KeyBoard('i', 'u', 0.5f);
                new KeyBoard('i', 'o', 0.5f);
                new KeyBoard('i', 'k', 0.5f);
                new KeyBoard('i', 'j', 0.3f);
                new KeyBoard('i', 'l', 0.3f);

                new KeyBoard('o', 'i', 0.5f);
                new KeyBoard('o', 'p', 0.5f);
                new KeyBoard('o', 'l', 0.5f);
                new KeyBoard('o', 'k', 0.3f);

                new KeyBoard('p', 'o', 0.5f);
                new KeyBoard('p', 'l', 0.3f);

                new KeyBoard('a', 'q', 0.5f);
                new KeyBoard('a', 's', 0.5f);
                new KeyBoard('a', 'z', 0.3f);
                new KeyBoard('a', 'w', 0.3f);
                new KeyBoard('a', 'x', 0.1f);

                new KeyBoard('s', 'a', 0.5f);
                new KeyBoard('s', 'd', 0.5f);
                new KeyBoard('s', 'w', 0.5f);
                new KeyBoard('s', 'x', 0.3f);
                new KeyBoard('s', 'q', 0.3f);
                new KeyBoard('s', 'e', 0.3f);
                new KeyBoard('s', 'z', 0.3f);
                new KeyBoard('s', 'c', 0.1f);

                new KeyBoard('d', 'e', 0.5f);
                new KeyBoard('d', 's', 0.5f);
                new KeyBoard('d', 'f', 0.5f);
                new KeyBoard('d', 'c', 0.3f);
                new KeyBoard('d', 'w', 0.3f);
                new KeyBoard('d', 'r', 0.3f);
                new KeyBoard('d', 'x', 0.3f);
                new KeyBoard('d', 'v', 0.1f);

                new KeyBoard('f', 'r', 0.5f);
                new KeyBoard('f', 'd', 0.5f);
                new KeyBoard('f', 'g', 0.5f);
                new KeyBoard('f', 'v', 0.3f);
                new KeyBoard('f', 'e', 0.3f);
                new KeyBoard('f', 't', 0.3f);
                new KeyBoard('f', 'c', 0.3f);
                new KeyBoard('f', 'b', 0.1f);

                new KeyBoard('g', 't', 0.5f);
                new KeyBoard('g', 'f', 0.5f);
                new KeyBoard('g', 'h', 0.5f);
                new KeyBoard('g', 'b', 0.3f);
                new KeyBoard('g', 'r', 0.3f);
                new KeyBoard('g', 'y', 0.3f);
                new KeyBoard('g', 'v', 0.3f);
                new KeyBoard('g', 'n', 0.1f);

                new KeyBoard('h', 'y', 0.5f);
                new KeyBoard('h', 'g', 0.5f);
                new KeyBoard('h', 'j', 0.5f);
                new KeyBoard('h', 'n', 0.3f);
                new KeyBoard('h', 't', 0.3f);
                new KeyBoard('h', 'u', 0.3f);
                new KeyBoard('h', 'b', 0.3f);
                new KeyBoard('h', 'm', 0.1f);

                new KeyBoard('j', 'u', 0.5f);
                new KeyBoard('j', 'h', 0.5f);
                new KeyBoard('j', 'k', 0.5f);
                new KeyBoard('j', 'm', 0.3f);
                new KeyBoard('j', 'n', 0.3f);
                new KeyBoard('j', 'y', 0.3f);
                new KeyBoard('j', 'i', 0.3f);

                new KeyBoard('k', 'i', 0.5f);
                new KeyBoard('k', 'j', 0.5f);
                new KeyBoard('k', 'l', 0.5f);
                new KeyBoard('k', 'm', 0.3f);
                new KeyBoard('k', 'u', 0.3f);
                new KeyBoard('k', 'o', 0.3f);

                new KeyBoard('l', 'o', 0.5f);
                new KeyBoard('l', 'k', 0.5f);
                new KeyBoard('l', 'i', 0.3f);
                new KeyBoard('l', 'p', 0.3f);

                new KeyBoard('z', 'x', 0.5f);
                new KeyBoard('z', 'a', 0.3f);
                new KeyBoard('z', 's', 0.3f);

                new KeyBoard('x', 'z', 0.5f);
                new KeyBoard('x', 'c', 0.5f);
                new KeyBoard('x', 's', 0.3f);
                new KeyBoard('x', 'd', 0.3f);

                new KeyBoard('c', 'x', 0.5f);
                new KeyBoard('c', 'v', 0.5f);
                new KeyBoard('c', 'd', 0.3f);
                new KeyBoard('c', 'f', 0.3f);

                new KeyBoard('v', 'c', 0.5f);
                new KeyBoard('v', 'b', 0.5f);
                new KeyBoard('v', 'f', 0.3f);
                new KeyBoard('v', 'g', 0.3f);

                new KeyBoard('b', 'v', 0.5f);
                new KeyBoard('b', 'n', 0.5f);
                new KeyBoard('b', 'g', 0.3f);
                new KeyBoard('b', 'h', 0.3f);

                new KeyBoard('n', 'b', 0.5f);
                new KeyBoard('n', 'm', 0.5f);
                new KeyBoard('n', 'h', 0.3f);
                new KeyBoard('n', 'j', 0.3f);

                new KeyBoard('m', 'n', 0.5f);
                new KeyBoard('m', 'j', 0.3f);
                new KeyBoard('m', 'k', 0.3f);
            }
        }
    }
}