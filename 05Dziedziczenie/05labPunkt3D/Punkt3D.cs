using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05labPunkt3D
{
    class Punkt3D : Punkt
    {
        public double Z = 0;
        public Punkt3D(double x, double y,double z) : base(x,y)
        {
            this.Z = z;
        }
        public Punkt3D() { }
        public double dist(Punkt3D p)
        {
            return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y)+ (this.Z - p.Z));
        }
        public override String ToString() 
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
