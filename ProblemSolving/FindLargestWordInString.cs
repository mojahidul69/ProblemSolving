using System;
namespace ProblemSolving
{
    public class FindLargestWordInString
    {
        public void LargestWord()
        {
            string input = "Edabit is amazing Create a function that takes";
            string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int i = 0;

            foreach (string str in words)
            {
                if (str.Length > i)
                {
                    word = str;
                    i = str.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
