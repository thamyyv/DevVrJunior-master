﻿namespace Tasks
{
    public class Task2
    {
        /*
         * Construa um método que receba uma string contendo um valor e retorne um bool de acordo com a validação:
         * 
         * 3 Letras maiúsculas
         * 4 digitos (0-9)
         * 1 letra minúscula
         * 
         * Exemplos de entradas validas: 
         * 1 - ABC1234a
         * 2 - QAZ0987b
         * 3 - WSX1324c
         * 
         * Exemplos de entradas inválidas: 
         * 1 - ABC-1234
         * 2 - QAZ1987
         * 3 - abc1324
         * 4 - az111W
         */
        public static bool CheckInput(string input)
        {

            int countUpperCase = 0;
            int countLowerCase = 0;
            int countNumbers = 0;

            foreach (char character in input)
            {
                if (char.IsUpper(character))
                {
                    countUpperCase++;
                }
                else if (char.IsLower(character))
                {
                    countLowerCase++;
                }
                else if (char.IsDigit(character))
                {
                    countNumbers++;
                }
            }

            if (countUpperCase == 3 && countLowerCase == 1 && countNumbers == 4)
                return true;
            else
                return false;
        }
    }
}
