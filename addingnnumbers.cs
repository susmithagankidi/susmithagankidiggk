using System;
using System.Collections.Generic;

using System.Text;

using System.Linq;

public class Test

{

public static void Main()

{
     Console.WriteLine("Enter number 1");
     string term1 = Console.ReadLine();
   
Console.WriteLine("Enter number2");
string term2 = Console.ReadLine();
   

    StringBuilder sum=new StringBuilder();

    int n1=term1.Length;

    int n2=term2.Length;

    int carry=0;

    int n=(n1>n2)?n1:n2;

    if(n1>n2)

    term2=term2.PadLeft(n1,'0');

    else

    term1=term1.PadLeft(n2,'0');

    for(int i=n-1;i>=0;i--)

    {

        int value=(carry+term1[i]-48+term2[i]-48)%10;

        sum.Append(value);

        carry=(carry+term1[i]-48+term2[i]-48)/10;

    }

    char[] c=sum.ToString().ToCharArray();

    Array.Reverse(c);

    Console.WriteLine(c);

}

}