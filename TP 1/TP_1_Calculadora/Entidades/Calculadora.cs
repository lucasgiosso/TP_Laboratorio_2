using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        ///  Realiza la operacion entre 2 números
        /// </summary>
        /// <param name="num1">Primer Operando</param>
        /// <param name="num2">Segundo Operando</param>
        /// <param name="operador">Ejecucion del operador elegido</param>
        /// <returns>Retorna el resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorChar;

                operadorChar = ValidarOperador(operador);

                switch (operadorChar)
                {
                    case '-':
                        return num1 - num2;

                    case '*':
                        return num1 * num2;

                    case '/':
                        return num1 / num2;

                    default:
                        return num1 + num2;
                }

        }

        /// <summary>
        /// Verifica si el operador es correcto.
        /// </summary>
        /// <param name="operador">Campo a validar</param>
        /// <returns>Retorna que el operador sea el seleccionado, sino devuelve "+".</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorCalculadora;

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                operadorCalculadora = operador;
            }
            else
            {
                operador = '+';

            }
            return operador;
        }
    }
}
