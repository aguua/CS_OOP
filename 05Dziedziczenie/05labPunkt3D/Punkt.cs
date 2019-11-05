using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05labPunkt3D
{
    class Punkt
    {
        public double X = 0, Y = 0;

        public Punkt(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public Punkt() { }
        public double dist(Punkt p)
        {
            return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y));
        }

        public override String ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
