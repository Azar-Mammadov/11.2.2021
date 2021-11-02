using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
         * Massivin elementlerin cemle
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 3 };
            
            Console.WriteLine(arry(arr));
        }

        public static int arry(int[] arr) {
            int sum = 0;
          
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;

        }
        */



        /*
         // verilen eded massivin icerisinde var ya yox?
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int a = Convert.ToInt32(Console.ReadLine());
           // argu(arr);
            bool tr = argu(arr,a);
           
            Console.WriteLine(tr);
        }
        
        
        
        //

       // 2 cur yazmaq olar
         public static string argu(int[] arr,int a)
         {
             string tr = "True", fl="False";

             foreach (int item in arr)
             {

                 if (item == a)
                 {
                     return tr;  
                 }                
             }
             return fl;
         }
        
        
        //




        public static bool argu(int[] arr, int a)
        {
       //     string tr = "True", fl = "False";

            foreach (int item in arr)
            {

                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }*/

        static void Main(string[] args)
        {
            string a = Convert.ToString(Console.ReadLine());
            int c = argument(a);
            Console.WriteLine(c);
        }

        public static int argument(string a)
        {
            int c=1, i=0,say=0;
            for ( i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' && a[i+1]!=' ')
                {
                    c++;
                }
            }   
            return c;
        }
    }
}
