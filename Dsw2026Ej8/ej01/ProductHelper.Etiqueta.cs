using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej01
{
    partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(Product p)
        {
            return $"[{p.getCode().ToString()}] {p.getDescription().ToString()} - {ObtenerFormato(p.getPrice())}";
        }
    }
}
