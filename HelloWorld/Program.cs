using System;
using System.Collections.Generic;   //Using statements are used to reference built it library with in VS. this gives our program access to those separate librarys of classes and methods
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld //namespace hold a collection of classes and methods. where our program lives.
{
    class Program //class holds or methods that live in the class and also names the class which can be used to access the methods within the class "house".
    {
        //string arg = HelloWorld;
        static void Main(string[] args)//method the uses the keyword "main" is where the programs execution would start or begin.
        {
            
            Console.WriteLine(args[0] + args[1]);
            Console.ReadLine();

        }
        
    }
}
