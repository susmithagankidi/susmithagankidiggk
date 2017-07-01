using System;

namespace floatadd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("enter the second number");
            string input2 = Console.ReadLine();  

            double firstnumber = Convert.ToDouble(input1);
            double secondnumber = Convert.ToDouble(input2);
            
            int integralpart1 = (int)firstnumber;
            int integralpart2 = (int)secondnumber;
            
            double decimalpart1 = firstnumber - integralpart1;
            double decimalpart2 = secondnumber - integralpart2;
            
            int convertedInteger1 = int_to_binary(integralpart1); 
            int convertedInteger2 = int_to_binary(integralpart2);        //convert integer part into binary value
            int int_to_binary(int k) {
                if (k == 0) return 0;
                if (k == 1) return 1;  
                return (k % 2) + 10 * int_to_binary(k / 2);
             }
            
            string floatarr1 = decimal_to_binary(decimalpart1);   
            string floatarr2 = decimal_to_binary(decimalpart2);  
            
            string decimal_to_binary(double deci) {                          //converting decimal to binary values
                double a = deci,b,c = 0.1;
                string arr = "";
                while( c > 0.001)       
                {
                    b = a*2;
                    arr += ((int)b).ToString(); 
                    c = c/10;
                    a = b - (int)b;  
                }
                return arr;
            }
    
            int carry = 0,p = 0,q = 0, tempsize = 0, tempsize1 = 0, rem, ansI = 0, factor = 1, y = -1;           // p = size of binary value of  decimal value after addition  q = size of binary value of  integers after addition 
            int[] result2 = new int[1000];       //addition of two integer parts
            int[] result1 = new int[1000];       //addition of two decimal parts
            
            int Floattoint1 = Int32.Parse(floatarr1);  //string first decimal array is converted into integer array 
            int Floattoint2 = Int32.Parse(floatarr2);  //string second decimal array is converted into integer array 
            
            while ( (Floattoint1 != 0) || (Floattoint2 != 0) )  //adding two decimal parts
            {
                result1[p++] = (Floattoint1 % 10 + Floattoint2 % 10 + carry) % 2;
                carry = ((Floattoint1  % 10 + Floattoint2 % 10 + carry) > 1) ? 1 : 0  ; 
                Floattoint1 = Floattoint1 / 10;
                Floattoint2 = Floattoint2 / 10;               
            }

            result1[p++] = (carry != 0) ? carry : (carry = 0) ;
            int[] FinalFact = new int[p];   //integer array after addition of decimal numbers
            
            while ( p > 0 )             //reverse the result of adding two decimal numbers
            {
               FinalFact[tempsize] = result1[--p]; 
                tempsize++;   
            }
            
            while ( (convertedInteger1 != 0) || (convertedInteger2 != 0) )             //adding two integral numbers
            {
                result2[q++] = (convertedInteger1 % 10 + convertedInteger2 % 10 + carry) % 2;
                carry = ((convertedInteger1 % 10 + convertedInteger2 % 10 + carry) > 1) ? 1 : 0  ;
                 convertedInteger1 = convertedInteger1 / 10;
                 convertedInteger2 = convertedInteger2 / 10;                
            }
            result2[q++] = carry != 0 ? carry : carry = 0 ;
            
            int[] FinalFact1 = new int[q];         //integer array after addition of integer numbers
            while ( q > 0 )                       //reverse the result of adding two integral numbers
            {
               FinalFact1[tempsize1] = result2[--q]; 
                tempsize1++;   
            }
            
            for (int c = 0; c < tempsize1;c++){                      //print integer part addition
                Console.Write(FinalFact1[c]);
            }
            Console.Write(".");
              for (int c = 0; c < tempsize;c++){                      //print decimal part addition
                Console.Write(FinalFact[c]);
            }
            
             for(int x = tempsize1-1; x >= 0; x--)                         //convert integral binary value into decimal integer value
             {
                rem = FinalFact1[x] % 10;
                ansI = ansI + rem * factor;
                factor = factor * 2;   
             }

             rem = 0;
             double ansF = 0;
            
             for(int x = tempsize-1; x >= 0; x--, y--)                     //convert decimal binary value into decimal integer value
             {
                rem = FinalFact[x] % 10;
                ansF = ansF + rem * Math.Pow(2,y); 
              }
            
            Console.WriteLine();
            Console.Write( ansI + ansF );
        }
    }
}