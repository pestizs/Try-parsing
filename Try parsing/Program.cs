using System;

namespace Try_parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE between Parse and TryParse
            string string1 = "1000";
            string string2 = null;
            string string3 = "1000.8888";

            int result;                //result
            result = int.Parse(string1);    //1000
            result = int.Parse(string2);    //ArgumentNullExpection
            result = int.Parse(string3);    //FormatExpection

            bool parseSuccessful;                                  // result    parseSuccessful
            parseSuccessful = int.TryParse(string1, out result);   //1000       true         returns default value of type int
            parseSuccessful = int.TryParse(string2, out result);   //0          false         returns default value of type int
            parseSuccessful = int.TryParse(string3, out result);   //0          false          returns default value of type int
        }
    }
}
