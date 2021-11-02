using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassAAA cla = new ClassAAA();
            int[] arr1 = new int[] { 1, -2, 3, -4, 5, 0, -6, 7, 8 };
           
            Console.WriteLine(cla.argument(arr1));

        }

    }
}
