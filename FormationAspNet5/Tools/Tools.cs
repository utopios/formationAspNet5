using System;
using System.Diagnostics;
using FormationAspNet5.Models;

namespace FormationAspNet5.Tools
{
    public class Tools
    {
        public Tools()
        {
            Person p = new Person { FirstName = "ihab", LastName = "abadi" };
            //p.FirstName = "toto";
            var (firstName, _,address) = p;

            Debug.WriteLine(firstName);
            Debug.WriteLine(address);
        }

        //tuple
        public static (int,bool) GetTuples()
        {
            return (10, true);
        }


        public static bool isLetter(char c) => (c is (>= 'a' and <= 'z'));



    }
}
