using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class M5 : Bmw
    {
        public override void Year()
        {
            Console.WriteLine("2003");
        }
        public override void Color()
        {
            Console.WriteLine("Gray");
        }
        public override void MaxSpeed()
        {
            Console.WriteLine("250");
        }
        public override void Model()
        {
            Console.WriteLine("E39");
        }
    }
}
