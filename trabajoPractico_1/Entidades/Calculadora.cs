using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador recibido.
        /// </summary>
        /// <param name="operador">Operador redibido</param>
        /// <returns>
        /// Retorna el operador recibido si el mismo es "+","-","*" ó "/". Caso contrario, retornará "+".
        /// </returns>
        private static string ValidarOperador(string operador)
        {
            return (operador == "+" || operador == "-" || operador == "*" || operador == "/") ? operador : "+";
        }

        /// <summary>
        /// Lleva a cabo la operación deseada
        /// </summary>
        /// <param name="primerOperando">Primer operando</param>
        /// <param name="segundoOperando">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>
        /// Retorna el resultado de la operación, en caso de que el operador sea invalido retorna "-1"
        /// </returns>
        public static double Operar(Numero primerOperando, Numero segundoOperando, string operador)
        {
            switch (ValidarOperador(operador))
            {
                case "+":
                    return primerOperando + segundoOperando;
                case "-":
                    return primerOperando - segundoOperando;
                case "*":
                    return primerOperando * segundoOperando;
                case "/":
                    return (primerOperando / segundoOperando).ToString() == (0.0 / 0).ToString() ? double.MinValue : primerOperando / segundoOperando;
                default:
                    return 0;
            }
        }
    }
}
