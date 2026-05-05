using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8.ej05
{
    internal class Sale
    {
        string _producto;
        decimal _importe;
        int _cantidad;

        public Sale()
        {

        }

        public Sale(string producto, decimal importe, int cantidad)
        {
            this._producto = producto;
            this._importe = importe;
            this._cantidad = cantidad;
        }

        public virtual decimal CalculateTotal()
        {
            return 0;
        }

        public string getProducto() { return _producto; }
        public decimal getImporte() { return _importe; }
        public int getCantidad() {  return _cantidad; }

    }

    
}
