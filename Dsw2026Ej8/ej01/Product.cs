using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void ModificarDescripcion(string nuevadescripcion) //método para ej03
        {
          setDescription(nuevadescripcion);

        }

        public long getCode() { return _code; }
        public string getDescription() { return _description; }
        public decimal getPrice() { return _price; }
        public void setDescription(string description) { _description = description; }
        public void setCode(long code) { _code = code; }
        public void setPrice(decimal price) { _price = price; }
    }
}
