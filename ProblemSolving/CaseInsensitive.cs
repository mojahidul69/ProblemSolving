namespace ProblemSolving
{
    public class CaseInsensitive
    {
        public string str1;
        public string str2;
        public bool CaseInsen()
        {
            bool flag = false;
            if (str1.ToUpper() == str2.ToUpper())
            {
                flag = true;
            }
            return flag;
        }
        /*CaseInsensitive caseInsensitive = new CaseInsensitive();

        string str1 = "hello";
        string str2 = "hEllo";
        caseInsensitive.str1 = str1;
        caseInsensitive.str2 = str2;

        Console.WriteLine(caseInsensitive.CaseInsen());*/
    }
}
