using System;

namespace ast2
{
    class Methodsfloat
    {
        // method for converting the integral part to binary
      
        public int integral2binary(int k)
        {  
             if(k==0) return 0;
              if (k==1) return 1;
              return (k %2) +10 *integral2binary(k/2);  
        }
       
        // method for converting decimal part to binary
         public string decimal2binary(double decimalpart)
         {
             double a = decimalpart;
             double b;
             double c = 0.1;
             string s ="";
             while(c>0.0000001)
             {
              b = a*2;
              s += ((int)b).ToString();
              c=c/10;
              a=b-(int)b;
             }
             return s;
        }

        // method for adding the binary version of integral parts
       public string integraladditionsum(int firstnumberintegralpartconverted,int secondnumberintegralpartconverted)
            {
              string intgl = "";
             int carry=0;
             while((firstnumberintegralpartconverted)!=0 || (secondnumberintegralpartconverted)!=0)
             {
                intgl+=((firstnumberintegralpartconverted %10) + (secondnumberintegralpartconverted %10) +(carry))%2;
                carry = ((firstnumberintegralpartconverted %10) +(secondnumberintegralpartconverted %10) +(carry)) >1 ? 1 :0;
                firstnumberintegralpartconverted = firstnumberintegralpartconverted/10;
                secondnumberintegralpartconverted = secondnumberintegralpartconverted/10;

             }
             intgl=intgl+carry;
             return intgl;
            }

        // method for adding binary version of decimal parts
        public string decimaladditionsum(string firstnumberdecimalpartconverted,string secondnumberdecimalpartconverted)
        {
            int dec1pt = Int32.Parse(firstnumberdecimalpartconverted);
            int dec2pt = Int32.Parse(secondnumberdecimalpartconverted);
            string dec = "";
            int carry=0;
             while((dec1pt)!=0 || (dec2pt)!=0)
           {
               dec+=((dec1pt)%10 +(dec2pt)%10+carry)%2;
               carry = (((dec1pt)%10 +(dec2pt)%10 + carry)>1)? 1 : 0;
               dec1pt=dec1pt/10;
              dec2pt=dec2pt/10;
           }
           dec=dec+carry;
           return dec;
          
        }

        // method to perform reverse of a string
        public string reversing(string k)
       {
         string reverse="";
         int Length;
         Length=k.Length -1;
         while (Length >=0)
         {
             reverse = reverse +k[Length];
             Length--;
         }
         return reverse;
       }
// method to convert the integral sum to normal number
public string normalintegral(string integralsumcorrect)
{
   string decval="";
    int decimal_val=0;
    int x=1;
    int rem;
    int binary_val =Int32.Parse(integralsumcorrect);

    while (binary_val >0)
    {
        rem = binary_val %10;
        decimal_val = decimal_val +rem *x;
        binary_val = binary_val/10;
        x=x*2;
    }
     decval+=decimal_val;
     return decval;
}


// method to convert the decimal sum to normal number
public string normaldecimal(string resultofdecimal)
{
    string decmant="";
    double decimal_val=0;
    double x=Math.Pow(2,-1);
    int rem;
    int binary_val=Int32.Parse(resultofdecimal);
    while (binary_val >0)
    {
        rem=binary_val %10;
        decimal_val = decimal_val + rem *x;
        binary_val = binary_val/10;
        x=x*Math.Pow(2,-1);
    }
    decmant+=decimal_val;
    Console.WriteLine(decmant);
    return decmant;

}
// method to produce original result
public string total(string normalintegral,string y)
{
    //string str ="";
    float a = float.Parse(normalintegral);
    float b = float.Parse(y);
    float c = a +b;
    string strrr = Convert.ToString(c);
    return strrr;
}
               
    }
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
           
           // calling integral2binary method in main method
        Methodsfloat m = new Methodsfloat();
        int firstnumberintegralpartconverted = m.integral2binary(integralpart1);
        int secondnumberintegralpartconverted = m.integral2binary(integralpart2);
          Console.WriteLine("The integral part of first number binary version :");
          Console.Write(firstnumberintegralpartconverted);
          Console.WriteLine();
          Console.WriteLine("The integral part of second number binary version :");
          Console.Write(secondnumberintegralpartconverted);
          Console.WriteLine();
           
        // calling decimal2binary method in main method
        string firstnumberdecimalpartconverted = m.decimal2binary(decimalpart1);
        string secondnumberdecimalpartconverted = m.decimal2binary(decimalpart2);
        Console.WriteLine("The decimal part of first number binary version :");
          Console.Write(firstnumberdecimalpartconverted);
          Console.WriteLine();
          Console.WriteLine("The decimal part of second number binary version :");
          Console.Write(secondnumberdecimalpartconverted);
          Console.WriteLine();
          
          // calling the sum of integral parts method
         string resultofintegral = m.integraladditionsum(firstnumberintegralpartconverted,secondnumberintegralpartconverted);
         Console.WriteLine("The sum of integral parts which is displayed reverse");
         Console.WriteLine(resultofintegral);
         
         //calling the sum of decimal parts method
        string resultofdecimal = m.decimaladditionsum(firstnumberdecimalpartconverted,secondnumberdecimalpartconverted);
        Console.WriteLine("The sum of decimal parts displayed reverse");
        Console.WriteLine(resultofdecimal);
       
       // calling the reverse method
       string integralsumcorrect = m.reversing(resultofintegral);
       Console.WriteLine("The result of integral sum is :{0} ",integralsumcorrect);
      string decimalsumcorrect = m.reversing(resultofdecimal);
       Console.WriteLine("The result of decimal sum is :{0}  ",decimalsumcorrect);
     // calling the normal integral method
     string normalintegral = m.normalintegral(integralsumcorrect);
     Console.WriteLine("The normal integral in decimal : {0} ", normalintegral);
     string y=m.normaldecimal(resultofdecimal);
     Console.WriteLine("the conversion before reversing is :{0}",y);
     
     string totalsum=m.total(normalintegral,y);
     Console.WriteLine("The total sum is {0}",totalsum);

   /* float a = float.Parse(normalintegral);
    float b = float.Parse(y);
    Console.WriteLine(a);
    Console.WriteLine(b);
    float c = a + b;
    Console.Write(c);*/


        }
    }
}

