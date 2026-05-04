using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej02
{
    internal class Problema2
    {
        public static string CrearResumenVenta(Product2 p)

        {
            decimal total = 0;

            if (p.getQuantity() > 0)
            {

                total = (decimal)(p.getQuantity() * p.getUnitPrice());

            } else { total = 0; }

            var etiqueta = new
            {

                Code = p.getProductCode(),
                Description = p.getProductDescription(),
                Quantity = p.getQuantity(),
                Total = total,

            };

            return $"{etiqueta.Code}-{etiqueta.Description}-{etiqueta.Total:C2}";
        }
    }
}
