using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_h_m_16
{
    public class Rectangle<T> : Shape
    {
        public T a;
        public T b;
        public Rectangle(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public override void GetArea()
        {
            try
            {
                int x = Convert.ToInt32(a);
                int y = Convert.ToInt32(b);
                Console.WriteLine($"Tort Burchak yuzasi: {x * y}");
            }
            catch
            {
                Console.WriteLine("Error!!");
            }
        }
    }
}
