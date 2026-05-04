using Dsw2026Ej8.ej01;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dsw2026Ej8.ej03
{
    internal class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
            int copiaValue = originalValue;
            copiaValue++;

            var producto2 = product; //utilizo clase producto del ej01
            producto2.ModificarDescripcion("mayonesa");
            

            return $"{originalValue}-{copiaValue}-{product.getDescription().ToString()}";
     
           
        }
    }
}
