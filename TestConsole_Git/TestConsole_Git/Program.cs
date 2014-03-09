using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole_Git
{
    class Program
    {
        static void Main(string[] args)
        {            
            // added 1 comment from visual studio git
            // added 2 comment git
            Console.WriteLine("Calculator");
        
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            double total = double.Parse(a) + double.Parse(b);

            Console.WriteLine( "a + b ="  + total  );

            Console.ReadLine();
           

        }

       
    }
}
