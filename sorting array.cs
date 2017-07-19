using System;

namespace sorting
{
    class Printingarray
    {
        public  int[] printingarray(int [] array,int x,int y)
        {
              //int [] array = new int[16];
              Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
                {
                  array[i] = randNum.Next(x,y);
                  Console.WriteLine(array[i]);
                }return array;
        }
    }
    class Sortingarray
    {
        public int[] sortingarray (int[] arrr)
        {
            for (int i = 0; i < arrr.Length; ++i)
    {
        for (int j = i + 1; j < arrr.Length; ++j)
        {
            if (arrr[i] > arrr[j])
            {
                int a =  arrr[i];
                arrr[i] = arrr[j];
                arrr[j] = a;
            }
        }
    } return arrr;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 15;
            int [] array = new int[16];
            Random randNum = new Random();
            Printingarray p = new Printingarray();
            Sortingarray s = new Sortingarray();
            int [] arr1 = p.printingarray(array,min,max);
            int [] arr2 = s.sortingarray(arr1);
   
    Console.WriteLine("sorted array");
        for (int i = 0; i < arr2.Length; ++i)
        Console.WriteLine( arr2[i]);
        }
    }
}
