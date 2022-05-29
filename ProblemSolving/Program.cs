using System;
namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hEllo";

            if (str1.ToUpper() == str2.ToUpper())
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
