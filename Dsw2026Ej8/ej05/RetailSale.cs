using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej05
{
    internal class RetailSale : Sale
    {
        public RetailSale(string producto, decimal importe, int cantidad) : base(producto, importe, cantidad)
        {
        }
        public override decimal CalculateTotal()
        {
            decimal total = getCantidad()*getImporte();
            return total;

            
        }
    }
}
