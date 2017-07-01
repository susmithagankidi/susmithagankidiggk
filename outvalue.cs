using System;

namespace passingparameters
{
    class Program
    {
        static void somefunction(int j,out int i)
        {
         i=20;
         j=100;
        }
        static void Main(string[] args)
        {
            int i =0;
            int j = 20;
            // Displaying the original values
            Console.WriteLine("The original value if i "+i);
            Console.WriteLine("The original value of j "+j);
           // calling the method somefunction
           somefunction(j,out i);
           Console.WriteLine("i= "+i);
           Console.WriteLine("j = " +j);
        }
    }
}
