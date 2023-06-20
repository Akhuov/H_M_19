using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_h_m_16
{
    public class Сircle<T>: Shape
    {
        public Сircle(T r)
        {
            this.r = r;
        }
        public T r { get; set; }

        public override void GetArea()
        {
            try
            {
                int a = Convert.ToInt32(r);
                Console.WriteLine($"Doiraning yuzasi: {Math.PI * ((double)(a ^ 2))}");
            }
            catch 
            {
                Console.WriteLine("Error!!");
            }
        }
    }
}
