using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej01
{
    partial class ProductHelper
    {
        public static string ObtenerFormato(decimal precio)
        {
            return $"{precio:C2}";

        }
    }
}
