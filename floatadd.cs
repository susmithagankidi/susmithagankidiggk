
using System;

namespace floatadd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,j=1,bin1=0,bin2=0;
            float k=0.1f;
            float s=0.1f;
            float temp1,binaryfract1=0;
            float temp2,binaryfract2=0;
            //float number1;
            //float number2;
            //double[]sumintegral = new double [50];
            //int p=0,rem=0;

            Console.WriteLine("Enter the float value1");
            float n1= float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the float value2");
            float n2=float.Parse(Console.ReadLine());
            Console.WriteLine("The value of float1 = {0} ",n1);
            Console.WriteLine("The value of float2 = {0}",n2);

            // seperating integral value from float
             int integral1 = (int)n1;
             int integral2 = (int)n2;
            Console.WriteLine("The value of integral part for float1 = {0} ",integral1);
            Console.WriteLine("The value of integral part for float2 = {0} ",integral2);

            // seperating fractional values from float
             float fractional1 = n1 -(int)n1;
             float fractional2 = n2 -(int)n2;
             Console.WriteLine("The value of fractional part for float1 = {0}",fractional1);
             Console.WriteLine("The value of fractional part for float2 = {0}",fractional2);
            
            // Convert decimal to binary
          // i=1;
           while(integral1>0)
           {
               bin1=bin1+((integral1)%2)*i;
               i=i*10;
               integral1=(integral1)/2;
           //Console.WriteLine(bin1);
           }   Console.WriteLine("the binary representation of the integral part of float1 (bin1) = {0} ",bin1);
           while(integral2>0)
           {
               bin2=bin2+((integral2)%2)*j;
               j=j*10;
               integral2=(integral2)/2;
           //Console.WriteLine(bin2);
        } Console.WriteLine("the binary representation of integral part of float2 (bin2) = {0}",bin2);
// Converting fractional value to binary 
 while (k>0.00000001)
 {
      temp1 = (fractional1)*2;
      binaryfract1 = (binaryfract1)+((int)temp1)*k;
      fractional1 = temp1 - (int)temp1;
      k=k/10;

 }
 //Console.WriteLine("binaryfract1");
 Console.WriteLine("The binary representation of fractioal part of float1 (binaryfract1) = {0}",binaryfract1);

while (s>0.00000001)
 {
      temp2 = (fractional2)*2;
      binaryfract2 = (binaryfract2)+((int)temp2)*s;
      fractional2 = temp2 - (int)temp2;
      s=s/10;

 }
 //Console.WriteLine("binaryfract2");
 Console.WriteLine("The binary representation of fractioal part of float2 (binaryfract2) = {0}",binaryfract2);
      // adding the integral parts of two numbers in binary
     

        }
     
    }
}
