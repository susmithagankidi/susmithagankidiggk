
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            
            // Convert decimal to binary (integral1)
        
             int p =0;
             int[] array1 = new int [5];
           while(integral1>0)
           {
               bin1=bin1+((integral1)%2)*i;
               i=i*10;
               array1[p] = (integral1)%2;
               p++;
               integral1=(integral1)/2;
        }   
             Console.WriteLine("the binary representation of the integral part of float1 (bin1) = {0} ",bin1);
            Console.WriteLine("The value of integral1 in array1 :");
   // storing the value of bin1 in an array 
   
       for (int m=0;m<p;m++){
           Console.Write(array1[m]);
       }
           
       Console.WriteLine();
      Array.Reverse(array1);
      Console.WriteLine("Reversed Array for integral1: ");
      foreach(int value in array1)
      {
          Console.Write(value);
      }
        
      Console.WriteLine();
      
// Converting integral2 to binary
          int q=0;
          int [] array2 = new int[5];
           while(integral2>0)
           {
               bin2=bin2+((integral2)%2)*j;
               j=j*10;
               array2[q]=(integral2)%2;
               q++;
               integral2=(integral2)/2;
           
        } 
        Console.WriteLine("the binary representation of integral part of float2 (bin2) = {0}",bin2);
        Console.WriteLine(" The value of integral2 in array2");

        // Storing the value of bin2 in an array.
        for (int n=0;n<q;n++)
        {
            Console.Write(array2[n]);
        }
            Console.WriteLine();
            Array.Reverse(array2);
      Console.WriteLine("Reversed Array for integral2: ");
      foreach(int value in array2)
      {
          Console.Write(value);
      }
        
      Console.WriteLine();

      // addition of integral part
      int carry=0,r=0;
      int [] sum = new int[5];
      for(r=0;r<5;r++)
      {
          sum[r]=(array1[5-r-1]+array2[5-r-1]+carry)%2;
          carry =((array1[5-r-1]+array2[5-r-1]+carry)%10)>1?1:0;

      }
          Console.WriteLine("The sum of integral parts ");
   foreach(int value in sum)
   {
       Console.Write(value);
   }
   Console.WriteLine();
   Array.Reverse(sum);
   Console.WriteLine("Reversed Array for sum: ");
   foreach(int value in sum)
   {
       Console.Write(value);
   }
   Console.WriteLine();
// Converting fractional value to binary 

 while (k>0.00000001)
 {
      temp1 = (fractional1)*2;
      binaryfract1 = (binaryfract1)+((int)temp1)*k;
      fractional1 = temp1 - (int)temp1;
      k=k/10;
  

 } Console.WriteLine("The binary representation of fractioal part of float1 (binaryfract1) = {0}",binaryfract1);
 
while (s>0.00000001)
 {
      temp2 = (fractional2)*2;
      binaryfract2 = (binaryfract2)+((int)temp2)*s;
      fractional2 = temp2 - (int)temp2;
      s=s/10;

 }
 //Console.WriteLine("binaryfract2");
 Console.WriteLine("The binary representation of fractioal part of float2 (binaryfract2) = {0}",binaryfract2);
 string str1,str2;
 str1 = binaryfract1.ToString("0.000000000");
 str2 = binaryfract2.ToString("0.000000000");
 Console.WriteLine(str1);
 Console.WriteLine(str2);
 char[] ch1 = new char[5];
 char[] ch2 = new char [5];
 ch1 = str1.ToCharArray();
 ch2 = str2.ToCharArray();
 Console.WriteLine("The character array for binaryfract1 :");
 Console.Write(ch1);
 Console.WriteLine();
 Console.WriteLine("The character array for binaryfract2 :");
 Console.WriteLine(ch2);

   int carryy=0,rr=0;
      int [] sum1 = new int[10];
      for(rr=0;rr<5;rr++)
      {
          sum[rr]=(ch1[5-rr-1]+ch2[5-rr-1]+carryy)%2;
          carry =((ch1[5-rr-1]+ch2[5-rr-1]+carryy)%10)>1?1:0;

      }
          Console.WriteLine("The sum of binaryfract parts ");
   foreach(int value in sum1)
   {
       Console.Write(value);
   }
   Console.WriteLine();
   Array.Reverse(sum1);
   Console.WriteLine("Reversed Array for sum1: ");
   foreach(int value in sum1)
   {
       Console.Write(value);
   }
   Console.WriteLine();

 
        }
    }
}

 