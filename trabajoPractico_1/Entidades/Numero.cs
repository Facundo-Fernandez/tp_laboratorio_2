using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Set del atributo numero en 0.
        /// </summary>
        public Numero() : this(0)
        {
        }

        /// <summary>
        /// Set del atributo "numero"
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>
        /// Retorna el string del numero guardado
        /// </returns>
        string SetNumero(string strNumero)
        {
            numero = ValidarNumero(strNumero);
            return numero == 0 ? "0" : strNumero;
        }

        /// <summary>
        /// Convierte un numero binario ingresado por parametro al sistema decimal
        /// </summary>
        /// <param name="numeroAConvertir">String con el numero a convertir</param>
        /// <returns>
        /// Retorna el resultado de la conversión o "Valor invalido" si el string pasado como parametro es invalido.
        /// </returns>
        public static string BinarioDecimal(string numeroAConvertir)
        {
            string numeroDecimal = "";
            double ret = 0;
            for (int i = 0; i < numeroAConvertir.Length; i++)
            {
                if (numeroAConvertir[i] != '1' && numeroAConvertir[i] != '0')
                    return "Valor invalido";
            }
            for (int i = 1; i <= numeroAConvertir.Length; i++)
            {
                ret += double.Parse(numeroAConvertir[i - 1].ToString()) * (Math.Pow(2, numeroAConvertir.Length - i));
            }
            numeroDecimal += ret;
            return numeroDecimal;
        }

        /// <summary>
        /// Convierte de string a double para usarlo como parametro en el metodo DecimalBinario
        /// </summary>
        /// <param name="numeroAConvertir">String con el numero a convertir</param>
        /// <returns>
        /// Retorna el resultado de la conversión o "Valor invalido" si el String pasado como parametro es invalido
        /// </returns>
        public static string DecimalBinario(string numeroAConvertir)
        {
            double numeroDecimal;
            for (int i = 0; i < numeroAConvertir.Length; i++)
            {
                if (numeroAConvertir[i] < '0' || numeroAConvertir[i] > '9')
                    return "Valor invalido";
            }
            return double.TryParse(numeroAConvertir, out numeroDecimal) ? DecimalBinario(numeroDecimal) : "Valor invalido";

        }

        /// <summary>
        /// Convierte un numero decimal ingresado por parametro al sistema binario.
        /// </summary>
        /// <param name="numeroAConvertir">Double con el numero a convertir</param>
        /// <returns>
        /// Retorna el resultado de la conversión o "Valor invalido" si el String pasado como parametro es invalido
        /// </returns>
        public static string DecimalBinario(double numeroAConvertir)
        {
            string numeroBinario = "";
            while ((int)numeroAConvertir > 0)
            {
                numeroBinario = ((int)numeroAConvertir % 2).ToString() + numeroBinario;
                numeroAConvertir = numeroAConvertir / 2;
            }
            return numeroBinario;
        }

        /// <summary>
        /// Set del atributo "numero" en el valor contenido en numero
        /// </summary>
        /// <param name="numero">Valor a setear</param>
        public Numero(double numero) : this(numero + "")
        {
        }

        /// <summary>
        /// Set del atributo "numero" en el valor contenido en numero
        /// </summary>
        /// <param name="numero">Valor a setear</param>
        public Numero(string numero)
        {
            SetNumero(numero);
        }

        /// <summary>
        /// Operador "-"
        /// </summary>
        /// <param name="minuendo">Valor a restar</param>
        /// <param name="sustraendo">Valor quie se resta</param>
        /// <returns>
        /// Retorna el resultado de la operación
        /// </returns>
        public static double operator -(Numero minuendo, Numero sustraendo)
        {
            return minuendo.numero - sustraendo.numero;
        }

        /// <summary>
        /// Operador "+"
        /// </summary>
        /// <param name="sumando1">Primer sumando</param>
        /// <param name="sumando2">Segundo sumando</param>
        /// <returns>
        /// Retorna el resultado de la operación
        /// </returns>
        public static double operator +(Numero sumando1, Numero sumando2)
        {
            return sumando1.numero + sumando2.numero;
        }

        /// <summary>
        /// Operador "/"
        /// </summary>
        /// <param name="dividendo">Dividendo</param>
        /// <param name="divisor">Divisor</param>
        /// <returns>
        /// Retorna el resultado de la operación
        /// </returns>
        public static double operator /(Numero dividendo, Numero divisor)
        {
            return dividendo.numero / divisor.numero;
        }

        /// <summary>
        /// Operador "*"
        /// </summary>
        /// <param name="factor1">Primer factor</param>
        /// <param name="factor2">Segundo factor</param>
        /// <returns>
        /// Retorna el resultado de la operación
        /// </returns>
        public static double operator *(Numero factor1, Numero factor2)
        {
            return factor1.numero * factor2.numero;
        }

        /// <summary>
        /// Cinvierte el valor ingresado como string a double           
        /// </summary>
        /// <param name="numeroAValidar">Valor a convertir</param>
        /// <returns>
        /// Retorna el valor ingresado como un double, caso contrario retorna 0.
        /// </returns>
        double ValidarNumero(string numeroAValidar)
        {
            double numero;

            return double.TryParse(numeroAValidar, out numero) ? numero : 0;
        }

    }
}

