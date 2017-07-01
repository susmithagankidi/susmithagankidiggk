using System;

namespace code43subpart
{
    public class Variable
    {
        public static int i = 5;
        public void test()
        {
            i=i+5;
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Variable var1 = new Variable();
            Console.WriteLine("the method is called first time :");
            var1.test();
            Variable var2 = new Variable();
            Console.WriteLine("the method is called second time: ");
            var2.test();
            Console.ReadLine();
        }
    }
}
