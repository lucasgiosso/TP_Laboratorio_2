using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Setea el número previa validación.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Constructor por defecto, asigna el numero 0.
        /// </summary>
        public Operando() : this(0)
        {

        }
        /// <summary>
        /// Constructor de tipo double que setea el valor enviado.
        /// </summary>
        /// <param name="numero">Numero a asignar</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor de tipo string que setea el valor enviado.
        /// </summary>
        /// <param name="strNumero">Numero a asignar</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Validar que el valor recibido sea un número.
        /// </summary>
        /// <param name="strNumero">Numero en tipo string que sea validara.</param>
        /// <returns>Retorna el numero validado, si no es valido devuelve 0.</returns>
        private static double ValidarOperando(string strNumero)
        {
            double numeroD;

            if (!(double.TryParse(strNumero, out numeroD)))
            {
                numeroD = 0;
            }
            return numeroD;
        }
        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="binario">Valor(Numero binario) a convertir.</param>
        /// <returns>Retorna un valor de tipo string con el número decimal.</returns>
        public string BinarioDecimal(string binario)
        {
            string numeroB = string.Empty;
            double numT = 0;
            int cantidadCaracteres = binario.Length;

            if (EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;

                    if (caracter == '1')
                    {
                        numT = numT + Math.Pow(2, cantidadCaracteres);
                    }
                }
                numeroB = numT.ToString();
            }
            else
            {
                numeroB = "Valor invalido";
            }

            return numeroB;

        }

        /// <summary>
        /// Valida si un numero de tipo string es binario.
        /// </summary>
        /// <param name="binario">Numero de tipo string a validar</param>
        /// <returns>Retorna el número binario si es valido, sino no.</returns>
        private bool EsBinario(string binario)
        {
            if (!string.IsNullOrWhiteSpace(binario))
            {
                for (int i = 0; i < binario.Length - 1; i++)
                {
                    if (binario[i] != '1' && binario[i] != '0')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Convierte un número decimal(entero positivo) de tipo double a binario.
        /// </summary>
        /// <param name="numero">Valor(Numero decimal) a convertir.</param>
        /// <returns>Retorna un valor de tipo string con el número binario.</returns>
        public string DecimalBinario(double numero)
        {
            string strBinario = string.Empty;
            int resulDiv = (int)Math.Abs(numero);
            int restoDiv;

            if (resulDiv >= 0)
            {
                do
                {
                    restoDiv = (int)resulDiv % 2;
                    resulDiv = (int)resulDiv / 2;
                    strBinario = restoDiv.ToString() + strBinario;

                } while (resulDiv > 0);
            }
            else
            {
                strBinario = "Valor invalido.";
            }

            return strBinario;
        }

        /// <summary>
        /// Convierte el valor recibido(número decimal y entero positivo) como string a binario.
        /// </summary>
        /// <param name="numero">Valor(Numero decimal) a convertir.</param>
        /// <returns>Retorna un valor de tipo string con el número binario.</returns>
        public string DecimalBinario(string numero)
        {
            double numeroD;
            string strNumero = "Valor invalido.";

            if (double.TryParse(numero, out numeroD))
            {
                strNumero = DecimalBinario(numeroD);
            }
            return strNumero;

        }

        /// <summary>
        /// Sobrecarga del operador de sumar
        /// </summary>
        /// <param name="n1">Valor 1 de tipo Numero</param>
        /// <param name="n2">Valor 2 de tipo Numero</param>
        /// <returns>Retorna la adicion de 2 números</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Sobrecarga del operador de restar
        /// </summary>
        /// <param name="n1">Valor 1 de tipo Numero</param>
        /// <param name="n2">Valor 2 de tipo Numero</param>
        /// <returns>Retorna la resta de 2 números</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Sobrecarga del operador de división
        /// </summary>
        /// <param name="n1">Valor 1 de tipo Numero</param>
        /// <param name="n2">Valor 2 de tipo Numero</param>
        /// <returns>Retorna la división de 2 números, si el resultado es 0 devuelve un valor minimo del tipo double.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double valorMinimo = double.MinValue;

            if (n2.numero != 0)
            {
                valorMinimo = n1.numero / n2.numero;
            }
            return valorMinimo;
        }

        /// <summary>
        /// Sobrecarga del operador de producto
        /// </summary>
        /// <param name="n1">Valor 1 de tipo Numero</param>
        /// <param name="n2">Valor 2 de tipo Numero</param>
        /// <returns>Retorna el producto de 2 números</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }
    }
}
