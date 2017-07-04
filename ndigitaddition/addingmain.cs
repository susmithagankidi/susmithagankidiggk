using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace assignment1
{
    class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter term 1");
            string term1 = Console.ReadLine();
            Console.WriteLine("Enter term 2");
            string term2 = Console.ReadLine();
            int n1 = term1.Length;
            int n2 = term2.Length;
            Console.WriteLine("term 1 length is {0}",n1);
            Console.WriteLine("term 2 length is {0}",n2);
           // Creating an object for class Methods 
           Methods p = new Methods();
           // Calling the method padding0
           string x= p.padding(term1,term2);
           if(n1>n2)
           {
              term2 = x;
           } 
           else
           {
               term1 = x;
           }
           
           Console.WriteLine("after padding "+term1);
           Console.WriteLine("after padding "+term2);
           // calling the method for calculating sum
            string res1=p.sumcalculation(term1,term2);
            Console.WriteLine("the added value in the string");
            Console.WriteLine(res1);
            // calling the method for reversing the string
            string res2 = p.reversing (res1);
            Console.WriteLine("sum of two n digit numbers ");
            Console.WriteLine(res2);


        }
    }
}
