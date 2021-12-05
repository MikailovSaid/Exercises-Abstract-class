using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            X5 x5 = new X5();
            x5.Model();
            x5.Year();
            x5.MaxSpeed();
            x5.Color();
            
            Console.WriteLine(" ");
            
            M5 m5 = new M5();
            m5.Model();
            m5.Year();
            m5.MaxSpeed();
            m5.Color();
            
            Console.WriteLine(" ");
            
            Mustang mustang = new Mustang();
            mustang.Model();
            mustang.Year();
            mustang.MaxSpeed();
            mustang.Color();
            
            Console.WriteLine(" ");
            
            F150 f150 = new F150();
            f150.Model();
            f150.Year();
            f150.MaxSpeed();
            f150.Color();
        }
    }
}