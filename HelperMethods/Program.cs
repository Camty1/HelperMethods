using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = superSecretFormula("World");
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula() // Private is interesting, I used it in unity so that the main editor could not change the values of variables, but never in functions.
        {
            // Some cool stuff here
            return "Hello World!"; // Same notation as Js
        }

        private static string superSecretFormula(string name) // Static means doesnt change?
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
