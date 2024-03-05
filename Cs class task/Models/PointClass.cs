using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Cs_class_task.Models
{
    internal class PointClass
    {
        public double x { get; set; }
        public double y { get; set; }

        public PointClass()
        {
            this.x = 0;
            this.y = 0;
        }

        public PointClass(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowData()
        {
            Console.WriteLine($"x={this.x}");
            Console.WriteLine($"y={this.y}");
        }
    }
}
