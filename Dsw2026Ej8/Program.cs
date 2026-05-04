using Dsw2026Ej8.ej01;
using Dsw2026Ej8.ej02;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Product a = new Product(123l, "sopa", 44M);
            Product b = new Product(988l, "fideo", 90.50M);
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(a));
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(b));
            */

            Product2 c = new Product2(1001, "fideos secos", 5, 20.50M);
            Console.WriteLine(Problema2.CrearResumenVenta(c));
            Product2 d = new Product2(3021, "salsa de tomate", 0, 15M);
            Console.WriteLine(Problema2.CrearResumenVenta(d));

        }
    }


    
}
