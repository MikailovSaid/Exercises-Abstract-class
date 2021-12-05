using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class X5 : Bmw
    {
        public override void Year()
        {
            Console.WriteLine("2006");
        }
        public override void Color()
        {
            Console.WriteLine("Blue");
        }
        public override void MaxSpeed()
        {
            Console.WriteLine("206");
        }
        public override void Model()
        {
            Console.WriteLine("E35");
        }
    }
}
