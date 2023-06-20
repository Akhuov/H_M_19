using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_h_m_16
{
    public class Triangle<T> : Shape
    {
        public Triangle(T a, T h)
        {
            this.h = h;
            this.a = a;
        }
        public T a { get; set; }
        public T h { get; set; }
        public override void GetArea()
        {
            try
            {
                double a1 = Convert.ToDouble(a);
                double h1 = Convert.ToDouble(h);
                Console.WriteLine($"Uchburchakning yuzasi: {(a1 / 2) * h1}");
            }
            catch 
            {
                Console.WriteLine("Error");
            }
        }
    }
}
