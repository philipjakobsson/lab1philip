using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string inmatning = ("3248923959235458236");
            Console.WriteLine(inmatning);
            ulong sum = 0;
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < inmatning.Length; i++)
            {
                if (Char.IsNumber(inmatning, i))
                {

                    char bookend = inmatning[i];
                    for (int j = i + 1; j < inmatning.Length; j++)
                    {
                        if (!Char.IsNumber(inmatning, j))
                        {
                            break;
                        }
                        if (inmatning[j] == bookend)
                        {
                            string pre = inmatning.Substring(0, i);
                            string mid = inmatning.Substring(i, j - i + 1);
                            string end = inmatning.Substring(j + 1, inmatning.Length - j - 1);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(pre);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(mid);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(end);
                            sum =+ sum + ulong.Parse(mid);
                            break;
                        }

                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Total summa: {sum}");
        }
    }
}
