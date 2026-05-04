using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej01
{
    internal class Product
    {
        long _code;
        string _description;
        decimal _price;

        public Product()
        {

        }

        public Product(long code, string description, decimal price)
        {
            this._code = code;
            this._price = price;
            this._description = description;
        }


        public long getCode() { return _code; }
        public string getDescription() { return _description; }
        public decimal getPrice() { return _price; }
    }
}
