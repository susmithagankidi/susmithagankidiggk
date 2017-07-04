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
        // method for adding numbers (strings here)
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
       // method for reversing the string
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
}
