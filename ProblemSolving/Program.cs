using System;
namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "solutaions";
            SingularPlural sPlural = new SingularPlural();
            Console.WriteLine(sPlural.LastCar(str));
        }
    }
}
