using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ej04
{
    internal class problema4
    {
        public static double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int contador = 0;
            int suma =0;
            double promedio = 0;
            
            if(nota1 is >= 0 and <=10)
            {
                suma+= nota1.Value;
                ++contador;

            } 

            if (nota2 is >= 0 and <= 10)
            {
                suma+=nota2.Value;
                ++contador;

            }
           
            if (nota3 is >= 0 and <= 10)
            {
                suma+=nota3.Value;
                ++contador;

            } 

            if(contador == 0) {

                Console.WriteLine($"Hay {contador} notas válidas");
                Console.WriteLine($"El promedio es: {promedio}");
                return promedio;
                
            }

            promedio = suma / contador;

            Console.WriteLine($"Hay {contador} notas válidas");
            Console.WriteLine($"El promedio es: {promedio}");
            return promedio;
            

        }
    }
}
