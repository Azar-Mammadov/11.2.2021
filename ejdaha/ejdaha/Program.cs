using System;

namespace ejdaha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emeliyyati daxil edin ( *, /, +, - )");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());
            ClassAA cl = new ClassAA();
            Console.WriteLine("Netice");
            Console.WriteLine(cl.ch(b, a, c)); 
        }
    }
}
