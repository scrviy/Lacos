using System;

namespace Lacos
{
    public class Lacos
    {
        static void Main(string[] args)
        {
            // Lacos Iterativos
            // Laco For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("o valor de i é " + i);
            }

            // Laco While
            int contador = 3;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Do .... while
            // execução garantida por pelo menos uma vez. Execute primeiro e depois testa a condicao.
            double j = 10;
            do 
            {
                Console.WriteLine(j);
                j = j * 1.5;
            }
            while ( j < 100 );

            // foreach
            // percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 7 };

            foreach (int numero in conjunto)
            {
                Console.WriteLine("Esse elemento tem valor " + numero + "! Somando esse valor a 10 temos " +
                (numero + 10));
            }
        }
    }

}