using System;

namespace ast2
{
    class Methodsfloat
    {
        // method for converting the integral part of a floating number to binary
      
        public int integral2binary(int k)
        {  
             if(k==0) return 0;
              if (k==1) return 1;
              return (k %2) +10 *integral2binary(k/2);  
        }
       
        // method for converting decimal part of a floating number to binary
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

        // method for adding the binary version of integral parts of the given two floating point numbers
       public string integraladditionsum(int firstnumberintegralpartconverted,int secondnumberintegralpartconverted)
            {
              string integralpartsaddition = "";
             int carry=0;
             while((firstnumberintegralpartconverted)!=0 || (secondnumberintegralpartconverted)!=0)
             {
                integralpartsaddition+=((firstnumberintegralpartconverted %10) + (secondnumberintegralpartconverted %10) +(carry))%2;
                carry = ((firstnumberintegralpartconverted %10) +(secondnumberintegralpartconverted %10) +(carry)) >1 ? 1 :0;
                firstnumberintegralpartconverted = firstnumberintegralpartconverted/10;
                secondnumberintegralpartconverted = secondnumberintegralpartconverted/10;

             }
             integralpartsaddition=integralpartsaddition+carry;
             return integralpartsaddition;
            }

        // method for adding binary version of decimal parts
        public string decimaladditionsum(string firstnumberdecimalpartconverted,string secondnumberdecimalpartconverted)
        {
            int decimalpartoffirstnumber = Int32.Parse(firstnumberdecimalpartconverted);
            int decimalpartofsecondnumber = Int32.Parse(secondnumberdecimalpartconverted);
            string decimalpartsaddition = "";
            int carry=0;
             while((decimalpartoffirstnumber)!=0 || (decimalpartofsecondnumber)!=0)
           {
               decimalpartsaddition+=((decimalpartoffirstnumber)%10 +(decimalpartofsecondnumber)%10+carry)%2;
               carry = (((decimalpartoffirstnumber)%10 +(decimalpartofsecondnumber)%10 + carry)>1)? 1 : 0;
               decimalpartoffirstnumber=decimalpartoffirstnumber/10;
              decimalpartofsecondnumber=decimalpartofsecondnumber/10;
           }
           decimalpartsaddition=decimalpartsaddition+carry;
           return decimalpartsaddition;
          
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
public string integraladditionsum_in_decimal(string integralsumindecimalformat)
{
   string decval="";
    int decimal_val=0;
    int x=1;
    int rem;
    int binary_val =Int32.Parse(integralsumindecimalformat);

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
public string decimaladditionsum_in_decimal(string resultingsumofdecimalpartsinbinary)
{
    string decimal_mantissa_string="";
    double decimal_val=0;
    double x=Math.Pow(2,-1);
    int rem;
    int binary_val=Int32.Parse(resultingsumofdecimalpartsinbinary);
    while (binary_val >0)
    {
        rem=binary_val %10;
        decimal_val = decimal_val + rem *x;
        binary_val = binary_val/10;
        x=x*Math.Pow(2,-1);
    }
    decimal_mantissa_string+=decimal_val;
    return decimal_mantissa_string;

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
}