using Dsw2026Ej8.ej01;
using Dsw2026Ej8.ej02;
using Dsw2026Ej8.ej03;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBAS EJ 01");
            Product a = new Product(123l, "sopa", 44M);
            Product b = new Product(988l, "fideo", 90.50M);
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(a));
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(b));
            Console.WriteLine("--------");

            Console.WriteLine("PRUEBAS EJ 02");
            Product2 c = new Product2(1001, "fideos", 5, 20.50M);
            Console.WriteLine(Problema2.CrearResumenVenta(c));
            Product2 d = new Product2(3021, "salsa de tomate", 0, 15M);
            Console.WriteLine(Problema2.CrearResumenVenta(d));
            Console.WriteLine("---------");


            Console.WriteLine("PRUEBAS EJ 03");
            Product e = new Product(2002, "sopa paraguaya", 20.90M);
            Console.WriteLine(Problema3.CompararCopias(34,e));
            Console.WriteLine("---------");
        }
    }


    
}
