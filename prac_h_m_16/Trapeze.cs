using prac_h_m_16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_h_m_16
{
    public class Trapeze<T> :Rectangle<T>
    {
        public Trapeze(T a, T b, T h) : base(a, b)
        {
            this.h = h;
        }
        public T h { get; set; }

        public override void GetArea()
        {
            try
            {
                double a1 = Convert.ToDouble(a);
                double b1 = Convert.ToDouble(b);
                double h1 = Convert.ToDouble(h);
                Console.WriteLine($"Trapetsiyaning yuzasi: {(a1 + b1) / 2 * h1}");
            } 
            catch
            {
                Console.WriteLine("Error!!");
            }
        }
    }
}
