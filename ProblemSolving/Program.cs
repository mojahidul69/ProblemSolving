using System;
namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "samurai";
            string str2 = "zi";
            string str11 = "";

            for (int i = str2.Length; i > 0; i--)
            {
                str11 += str1[str1.Length - i];
                Console.WriteLine(str11);
            }

            if (str11 == str2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
