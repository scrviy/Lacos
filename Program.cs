using System;

namespace Lacos
{
    public class Lacos
    {
        static void Main(string[] args)
        {
            //* Lacos Iterativos
            
            //For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("o valor de i é " + i);
            }

            //While
            int contador = 3;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Do .... while
            double j = 10;
            do 
            {
                Console.WriteLine(j);
                j = j * 1.5;
            }
            while ( j < 100 );

            //foreach
            int[] conjunto = { 1, 2, 3, 7 };

            foreach (int numero in conjunto)
            {
                Console.WriteLine("Esse elemento tem valor " + numero + "! Somando esse valor a 10 temos " +
                (numero + 10));
            }


            // Lacos condicionais
            int hora = 13;
            if (hora >= 15) //* Se a hora for maior ou igual a 15, será impressa a mensagem no console para usuário.
                Console.WriteLine("Já são 15H ou mais.");

            if (hora == 13)
                Console.WriteLine("A hora é igual a 13 Horas");
        }
    }

}