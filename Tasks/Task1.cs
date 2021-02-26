using System.Collections.Generic;

namespace Tasks
{
    public class Task1
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */

        public static int? GetMax(List<int> list) {
            int? maxNumber = null;
            foreach (int number in list)
            {
                if (maxNumber == null)
                {
                    maxNumber = number;
                }
                else
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                    // maxNumber = number > maxNumber ? number : maxNumber;
                }
            }
            return maxNumber;
        }
    }
}
