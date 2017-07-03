using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace assignment1
{
    class Methods
    {
        // method for padding zeros
        public string padding(string term1,string term2)
        { if (term1.Length > term2.Length)
           {
           term2= term2.PadLeft(term1.Length,'0');
           Console.WriteLine(term2);
           return term2;
           }
           else {
         term1= term1.PadLeft(term2.Length,'0');
         Console.WriteLine(term1);
         return term1; }
       }

       public string sumcalculation(string term1,string term2)
       {
           int carry = 0;
           String res = "";
           int n = (term1.Length>term2.Length) ? term1.Length:term2.Length;
           for( int i = n-1;i>=0;i--)
           {
            res+=(carry+term1[i]-'0'+term2[i]-'0')%10;
            carry=(carry+term1[i]-'0'+term2[i]-'0')/10;
           }
           res=res+carry;
           Console.WriteLine("The value of the sum in the string");
           Console.WriteLine(res);
           return res;
       }
       public string reversing(string res1)
       {
         string reverse="";
         int Length;
         Length=res1.Length -1;
         while (Length >=0)
         {
             reverse = reverse +res1[Length];
             Length--;
         }
         return reverse;
       }


    }

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
           // Calling the method padding
           string x= p.padding(term1,term2);
           if(n1>n2)
           {
              term2 = x;
           } 
           else
           {
               term1 = x;
           }
           
           Console.WriteLine("after padding"+term1);
           Console.WriteLine("after padding"+term2);
           // calling the method for calculating sum
            string res1=p.sumcalculation(term1,term2);
            Console.WriteLine("the added value in the string");
            Console.WriteLine(res1);
            // calling the method for reversing the string
            string res2 = p.reversing (res1);
            Console.WriteLine(res2);


        }
    }
}
