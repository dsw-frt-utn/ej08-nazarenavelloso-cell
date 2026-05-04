using Dsw2026Ej8.ej01;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product(123l, "sopa", 44M);
            Product b = new Product(988l, "fideo", 90.50M);
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(a));
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(b));

        }
    }
}
