using System;
using System.Collections.Generic;
using System.Text;

namespace ejdaha
{
    class ClassAA
    {
        public static int sum (int a, int c)
        {
            return a + c;
        }
        public static int minus (int a,int c)
        {
            return a - c;
        }
        public static int vur(int a,int c)
        {
            return a * c;
        }
        public static int bol(int a, int c)
        {
            return a / c;
        }
        public int ch(string b,int a, int c)
        {
            if (b == "+")
            {

                return sum(a, c);
            }
            else if(b=="-")
            {
                return minus(a, c);
            }
            else if(b=="*")
            {
                return vur (a, c);
            }
            return bol(a, c);
        }
    }
}
