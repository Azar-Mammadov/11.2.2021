using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassAAA
    {
        int[] arr = new int[] { 1, -2, 3, -4, 5, 0, -6, 7, 8 };


        public string argument(int[] arr)
        {
            int menfi_say = 0, musbet_say = 0, s_say = 0;
            foreach (int item in arr)
            {
                if (item > 0)
                {
                    musbet_say++;
                }
                else if (item < 0)
                {
                    menfi_say++;
                }
                else
                {
                    s_say++;
                }
            }
            return $"musbetlerin sayi =  {musbet_say}\nMenfilerin sayi = {menfi_say}\nSifirlarin sayi = {s_say}";
            //Console.WriteLine();
        } 
        }
}
