using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Intro_to_Methods_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int bugs;
            Console.WriteLine("How many bugs are in your code?");
            Int32.TryParse(Console.ReadLine(), out bugs);
            Joke(bugs);
            Console.ReadLine();
        }


        //Joke() is an overloaded method.  This means that there are more than 1 method 
        //with the same name.
        //The version of Joke() that is invoked will be determined by what (if any) arguments
        //are passed to it.
        
        //This version of Joke requires no arguments and will do exactly the same thing whenever it is called
        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(1000);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(1000);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(1000);
            Console.WriteLine("100 little bugs in the code.");
        }

        //The parameter numBugs will allow this method to behave slightly differently each time it is called
        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(1000);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(1000);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(1000);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }


    }
}
