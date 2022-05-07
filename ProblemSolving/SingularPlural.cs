namespace ProblemSolving
{
    public class SingularPlural
    {
        public bool LastCar(string str)
        {
            // bool
            /*int i = str.Length - 1;
            char nCar = str[i];
            //Console.WriteLine(nCar == 's');
            return nCar == 's';*/


            // If Condition
            /*int i = str.Length - 1;
            char nCar = str[i];
            bool b = false;
            if (nCar == 's')
            {
                b = true;
            }
            return b;*/


            // For loop
            string sFor = "";
            bool bFor = false;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sFor += str[i];

                if (sFor[0] == 's')
                {
                    bFor = true;
                }
            }
            return bFor;
        }
    }
}
/*string str = "solutaions";
SingularPlural sPlural = new SingularPlural();
Console.WriteLine(sPlural.LastCar(str));*/
