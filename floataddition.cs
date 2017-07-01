using System;

namespace floataddmethods
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
            Console.WriteLine("the integralpart1 :");
            Console.Write(integralpart1);
            Console.WriteLine();
            Console.WriteLine("The integralpart2 :");
            Console.Write(integralpart2);
            Console.WriteLine();
            double decimalpart1 = firstnumber - integralpart1;
            double decimalpart2 = secondnumber - integralpart2;
            Console.WriteLine("decimalpart1 :");
            Console.Write(decimalpart1);
            Console.WriteLine();
            Console.WriteLine("decimalpart2: ");
            Console.Write(decimalpart2);
            Console.WriteLine();
           
           // calling method 1 in main method
            
          int integralpart1converted = int_to_binary(integralpart1);
          int integralpart2converted = int_to_binary(integralpart2);
          Console.WriteLine("The integral part of first number :");
          Console.Write(integralpart1converted);
          Console.WriteLine();
          Console.WriteLine("The integral part of second number :");
          Console.Write(integralpart2converted);
          Console.WriteLine();
          

          // calling method2 in main method

          string decimalpart1converted = decimal_to_binary(decimalpart1);
          string decimalpart2converted= decimal_to_binary(decimalpart2);
          Console.WriteLine("The decimal part of first number :");
          Console.Write(decimalpart1converted);
          Console.WriteLine();
          Console.WriteLine("The decimal part of second number :");
          Console.Write(decimalpart2converted);
          Console.WriteLine();
          
          // Method 1
          
          int int_to_binary(int k)
          {
              if(k==0) return 0;
              if (k==1) return 1;
              return (k %2) +10 *int_to_binary(k/2);
          }
  
        // Method 2
          string decimal_to_binary(double decimalpart)
         {
             double a = decimalpart;
             double b;
             double c = 0.1;
             string array ="";

             while(c>0.0001)
             {
              b = a*2;
              array += ((int)b).ToString();
              c=c/10;
              a=b-(int)b;
             }
             return array;
         }

           
             // initialising two arrays to store the results of sum of integral and decimal parts
            
             int[] integralsum = new int[1000];
             int[] decimalsum = new int[1000];

           
           // sum of integral parts
             int q=0;
             int rev =0;
             int carry=0;
             while((integralpart1converted)!=0 || (integralpart2converted)!=0)
             {
                integralsum[q++] = (integralpart1converted %10 + integralpart2converted %10 +carry)%2;
                carry = ((integralpart1converted %10 +integralpart2converted %10 +carry)>1)? 1 :0;
                integralpart1converted = integralpart1converted/10;
                integralpart2converted = integralpart2converted/10;

             }
               integralsum[q++]= carry !=0 ? carry : carry = 0;
               int[]Finalintegralsum = new int[q];
               while (q >0)
               {
                   
                   Finalintegralsum[rev]=integralsum[--q];
                   rev++;
               }
               Console.WriteLine("The sum of integral parts is :");
               for(int d=0; d<rev; d++)
               {
                  
                   Console.Write(Finalintegralsum[d]);
               }
                   Console.WriteLine();

           // sum of decimalpart

           int decimalpart1sa = Int32.Parse(decimalpart1converted);
           int decimalpart2sa = Int32.Parse(decimalpart2converted);
           int revv=0;
           int p=0;

           while((decimalpart1sa)!=0 || (decimalpart2sa)!=0)
           {
               decimalsum[(p)++]=((decimalpart1sa)%10 +(decimalpart2sa)%10+carry)%2;
               carry = (((decimalpart1sa)%10 +(decimalpart2sa)%10 + carry)>1)? 1 : 0;
               decimalpart1sa=decimalpart1sa/10;
               decimalpart2sa=decimalpart2sa/10;
           }
           decimalsum[p++]= carry != 0 ? carry : carry = 0;
           int [] Finaldecimalsum = new int[p];
           while(p>0)
           {
               Finaldecimalsum[revv]=decimalsum[--p];
               revv++;
           } Console.WriteLine("Sum of decimal parts :");
               for(int d=0; d<revv; d++)
               {
                  
                   Console.Write(Finaldecimalsum[d]);
               } Console.WriteLine();


             }
         }

          }   
                        