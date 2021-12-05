using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class F150 : Ford
    {
        public override void Year()
        {
            Console.WriteLine("2004");
        }
        public override void Color()
        {
            Console.WriteLine("White");
        }
        public override void MaxSpeed()
        {
            Console.WriteLine("210");
        }
        public override void Model()
        {
            Console.WriteLine("Lightning");
        }
    }
}
