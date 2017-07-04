using System;

namespace ast2
{
    class Program
    {
        public static void Main(string[] args)
           {
            Console.WriteLine("Enter the first number");
            float firstnumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            float secondnumber = float.Parse(Console.ReadLine());
            int integralpart1=  (int)firstnumber;
            int integralpart2=  (int)secondnumber;
            Console.WriteLine("the integral part of first number is :{0} ",integralpart1);
            Console.WriteLine("The integral part of second number is : {0}",integralpart2);
            double decimalpart1 = firstnumber - integralpart1;
            double decimalpart2 = secondnumber - integralpart2;
            Console.WriteLine("the decimal part of first number is : {0}",decimalpart1);
            Console.WriteLine("the decimal part of second number is : {0}",decimalpart2);
           
           // calling integral2binary method in main method
        Methodsfloat m = new Methodsfloat();
        int firstnumberintegralpartconverted = m.integral2binary(integralpart1);
        int secondnumberintegralpartconverted = m.integral2binary(integralpart2);
          Console.WriteLine("The integral part of first number  in binary format is : {0}" ,firstnumberintegralpartconverted);
          Console.WriteLine("The integral part of second number in binary format is  : {0}",secondnumberintegralpartconverted);
           
        // calling decimal2binary method in main method
        string firstnumberdecimalpartconverted = m.decimal2binary(decimalpart1);
        string secondnumberdecimalpartconverted = m.decimal2binary(decimalpart2);
        Console.WriteLine("The decimal part of first number in binary format is : {0}",firstnumberdecimalpartconverted);
        Console.WriteLine("The decimal part of second number in binary format is :{0}",secondnumberdecimalpartconverted);  
          // calling the sum of integral parts method
         string resultingsumofintegralpartsinbinary = m.integraladditionsum(firstnumberintegralpartconverted,secondnumberintegralpartconverted);
         Console.WriteLine("The sum of integral parts of first number and second number  which is displayed in reverse is :{0}",resultingsumofintegralpartsinbinary);
         //calling the sum of decimal parts method
        string resultingsumofdecimalpartsinbinary = m.decimaladditionsum(firstnumberdecimalpartconverted,secondnumberdecimalpartconverted);
        Console.WriteLine("The sum of decimal parts of first number and second number which is  displayed in  reverse is :{0}",resultingsumofdecimalpartsinbinary);
       
       // calling the reverse method
       string integralsumindecimalformat = m.reversing(resultingsumofintegralpartsinbinary);
       Console.WriteLine("The sum of integral parts of first number and second number in binary format in correct form is  :{0} ",integralsumindecimalformat);
      string decimalsumcorrect = m.reversing(resultingsumofdecimalpartsinbinary);
       Console.WriteLine("The sum of decimal parts of first number and second number is binary format in correct form is  :{0}  ",decimalsumcorrect);
     // calling the normal integral method
     string normalintegral = m.integraladditionsum_in_decimal(integralsumindecimalformat);
     Console.WriteLine("The sum of integral parts converted to normal decimal representation is  : {0} ", normalintegral);
     // calling the normal decimal method
     string y=m.decimaladditionsum_in_decimal(resultingsumofdecimalpartsinbinary);
     Console.WriteLine("the sum of decimal parts converted to normal decimal representation is  :{0}",y);
     
     string totalsum=m.total(normalintegral,y);
     Console.WriteLine("The total sum of two floating point numbers given in decimal is  {0}",totalsum);
        }
    }
}

