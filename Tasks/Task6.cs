using System.Collections.Generic;
using System;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */

        public static List<decimal> GetRatios(List<int> numbers)
        {
            int positives = 0;
            int negatives = 0;
            int zeros = 0;
            int total;
            List<decimal> lista = new List<decimal>();

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positives++;
                }
                else if (number < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }

            total = positives + negatives + zeros;
            
            lista.Add(Math.Round(((decimal)positives/ total), 6));
            lista.Add(Math.Round(((decimal)negatives / total), 6));
            lista.Add(Math.Round(((decimal)zeros / total), 6));
            return lista;


        }
    }
}
