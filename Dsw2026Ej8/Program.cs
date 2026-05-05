using Dsw2026Ej8.ej01;
using Dsw2026Ej8.ej02;
using Dsw2026Ej8.ej03;
using Dsw2026Ej8.ej04;
using Dsw2026Ej8.ej05;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- PRUEBAS EJ 01 -----\n");
            Product a = new Product(123l, "sopa", 44M);
            Product b = new Product(988l, "fideo", 90.50M);
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(a));
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(b));

            Console.WriteLine("\n----- PRUEBAS EJ 02 -----\n");
            Product2 c = new Product2(1001, "fideos", 5, 20.50M);
            Console.WriteLine(Problema2.CrearResumenVenta(c));
            Product2 d = new Product2(3021, "salsa de tomate", 0, 15M);
            Console.WriteLine(Problema2.CrearResumenVenta(d));

            Console.WriteLine("\n----- PRUEBAS EJ 03 -----\n");
            Product e = new Product(2002, "sopa paraguaya", 20.90M);
            Console.WriteLine(Problema3.CompararCopias(34,e));

            Console.WriteLine("\n----- PRUEBAS EJ 04 -----\n");
            Console.WriteLine(problema4.CalcularPromedio(10, 8, 9));
            Console.WriteLine(problema4.CalcularPromedio(null, null,null));
            Console.WriteLine(problema4.CalcularPromedio(12, 8, 9));
            Console.WriteLine(problema4.CalcularPromedio(10, null, 9));
            Console.WriteLine(problema4.CalcularPromedio(null, 0, 5));

            Console.WriteLine("\n----- PRUEBAS EJ 05 -----\n");
            Sale s1 = new RetailSale("camisa", 20.50M, 5);
            Console.WriteLine(Problema5.ObtenerImporteFinal(s1));
            Sale s2 = new WholesaleSale("pantalon", 105.60M, 1);
            Console.WriteLine(Problema5.ObtenerImporteFinal(s2));
            Sale s3 = new WholesaleSale("medias", 10M, 5);
            Console.WriteLine(Problema5.ObtenerImporteFinal(s3));
            Sale s4 = new RetailSale("short", 200M, 2);
            Console.WriteLine(Problema5.ObtenerImporteFinal(s4));

            


        }
    }


    
}
