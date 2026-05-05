using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej05
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(string producto, decimal importe, int cantidad): base(producto, importe, cantidad)
        {
        }

        public override decimal CalculateTotal()
        {
            decimal total = getCantidad() * getImporte();
            decimal totaldescuento = total - (total * 0.10M);

            return totaldescuento;
        }
    }
}
