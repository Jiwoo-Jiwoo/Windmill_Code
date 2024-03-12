using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            int size = 15;
            bool temp = false;
            for (int y = 0; y < size * 2; y++)
            {
                for (int x = 0; x < size * 2; x++)
                {
                    if (x < size)
                    {
                        if (y < size) // 2
                        {
                            if (y <= x) temp = true;
                            else temp = false;
                        }
                        else // 3
                        {
                            if (size * 2 - 1 - y >= x) temp = true;
                            else temp = false;
                        }
                    }
                    else if (x >= size)
                    {
                        if (y < size) // 1
                        {
                            if (size * 2 - 1 - x <= y) temp = true;
                            else temp = false;
                        }
                        else // 4
                        {
                            if (x <= y) temp = true;
                            else temp = false;
                        }
                    }

                    if (temp) text += "*";
                    else text += " ";
                }
                text += "\n";
            }
            Console.WriteLine(text);
        }
    }
}
