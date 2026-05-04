using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej02
{
    internal class Product2
    {
        long _productCode;
        string _productDescription;
        int _quantity;
        decimal _unitPrice;

        public Product2()
        {

        }

        public Product2(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            this._productCode = productCode;
            this._productDescription = productDescription;
            this._quantity = quantity;
            this ._unitPrice = unitPrice;
        }


        public long getProductCode() { return _productCode; }
        public string getProductDescription() { return _productDescription; }
        public int getQuantity() { return _quantity; }

        public decimal getUnitPrice() { return _unitPrice;
    }

}
}
