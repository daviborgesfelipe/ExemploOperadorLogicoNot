using System;

namespace ExemploOperadorLogicoNot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*##### VARIÁVEIS #####*/
            bool resultado;
            /*##### VARIÁVEIS #####*/

            resultado = !(7 <= 4);
            //aqui o operador logico not(!) vai inverter o resultado da expressão que por questão de precedencia tem que ficar dentro de parenteses para ser executada primeiramente, sendo que esta verificando se sete é igual ou menor(<=) que quatro, no caso o valor desta expressão é false e, foi invertida para "true" pelo operador logico not (!).

            Console.WriteLine(resultado);
        }
    }
}
