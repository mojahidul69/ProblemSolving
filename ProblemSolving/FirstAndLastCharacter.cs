using System;
namespace ProblemSolving
{
    public class FirstAndLastCharacter
    {
        public void FirstAndLast(string name)
        {
            char[] cr = new char[] { name[0], name[name.Length - 1] };
            //name = new string(cr);
            Console.WriteLine(cr);

            /*char lchar = name[name.Length - 1];
            char fchar = name[0];
            Console.WriteLine(fchar + "" + lchar);*/
        }
        /*string name = "rahim";
        FirstAndLastCharacter first = new FirstAndLastCharacter();
        first.FirstAndLast(name);*/
    }
}
