using System;

namespace tasks11._2._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aylarin sira nomresini yazaraq hansi fesil oldugunu gore bilersiniz");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(argument(a));
        }
        public static string argument(int a)
        {
            string q = "Winter", yaz = "Spring", yay = "Summer", p="Autumn",islemir = "ilimizde 12 ay oldugu ucun sizin yazdiginiz uygun gelmir";
            if(a==12 || a==1 || a == 2)
            {
                return q;
            }
            else if(a>=3 && a <= 5)
            {
                return yaz;
            }
            else if(a>=6 && a<=8)
            {
                return yay;
            }
            else if(a>=9 && a<=11)
            {
                return p;
            }
            return islemir;
        }
    }
}
