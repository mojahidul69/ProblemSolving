using System;
namespace ProblemSolving
{
    public class StringEndingMatches
    {
        public void stringEnd()
        {
            string str1 = "samurai";
            string str2 = "urai";
            string rev = "";

            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i > 0; i--)
                {
                    rev += str1[str1.Length - i];
                }
                if (rev == str2)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                for (int i = str1.Length; i > 0; i--)
                {
                    rev += str2[str2.Length - i];
                }
                if (str1 == rev)
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
}
