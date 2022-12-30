using System;

namespace Lacos
{
    public class Lacos
    {
        static void Main(string[] args)
        {
            //* Lacos Iterativos

            /*

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

                */

            // Lacos condicionais
            // Lacos if - elseif - else
           
            int hora = 18;

            /*
            if (hora <= 15) //* Se a hora for menor ou igual a 15, será impressa a mensagem no console para usuário.
                Console.WriteLine("São menos que 15H.");

            else if (hora <= 17)
                Console.WriteLine("A hora é menor ou igual a 17!");

            else // o else garante a execucao do bloco de código seguinte a ele.
                {
                    if (hora == 18)
                        Console.WriteLine("São 18H.");
                    else
                        Console.WriteLine("Já passou das 18H");
                }
                */

            // laco switch
            switch (hora) // teste condicional é exato
            {
                case 15:
                    Console.WriteLine("São 15H.");
                    break;

                case 18:
                    Console.WriteLine("São 18H");
                    break;
            }
        }
    }

}