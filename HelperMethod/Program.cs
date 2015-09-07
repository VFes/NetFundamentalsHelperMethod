using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);

            string myValue2 = superSecretFormula("vic");
            Console.WriteLine(myValue2);



            Console.ReadLine();

        }//ends the main method

        private static string superSecretFormula()
        {
            //some cool stuff here
            return "Hello World";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}", name);

        }
    }
}
