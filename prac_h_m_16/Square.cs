
namespace prac_h_m_16
{
    public class Square<T>: Shape 
    {
        public T a;
        public Square(T a) 
        {
            this.a = a;
        }
        public override void GetArea()
        {
            try
            {
                int x = Convert.ToInt32(a);
                Console.WriteLine($"Kvadratning yuzasi: {x * x}");
            }
            catch 
            {
                Console.WriteLine("Error!!");
            }
        }
    }
}
