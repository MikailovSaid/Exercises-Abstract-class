using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Mustang : Ford
    {
        public override void Year()
        {
            Console.WriteLine("2016");
        }
        public override void Color()
        {
            Console.WriteLine("Red");
        }
        public override void MaxSpeed()
        {
            Console.WriteLine("280");
        }
        public override void Model()
        {
            Console.WriteLine("Shelby");
        }
    }
}
