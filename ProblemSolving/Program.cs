﻿using System;
namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmazingReplaceNotAmazing.input = "Edabit is amazing";
            string outP = AmazingReplaceNotAmazing.Amazing();
            Console.WriteLine(outP);
            /*string input = "Edabit is amazing";
            string[] words = input.Split(' ');

            string result = "";

            foreach (string str in words)
            {
                if (str == "Edabit")
                {
                    result = input;
                    break;
                }
                else
                {
                    result = input.Replace("amazing", "not amazing");
                }
            }
            Console.WriteLine(result);*/


            /*string input = "EdabitA is amazing";
            string[] words = input.Split(" ");
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Edabit")
                {
                    result = input;
                    break;
                    //Console.WriteLine(input);
                }
                else
                {
                    if (words[i] == "amazing")
                    {
                        words[i] = "not amazing";
                    }
                    result += words[i] + " ";
                    //result = input.Replace("amazing", "not amazing");
                    //Console.WriteLine(input.Replace("amazing", "not amazing"));
                }
            }
            Console.WriteLine(result);*/
        }
    }
}
