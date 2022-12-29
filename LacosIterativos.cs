
namespace LacosIterativos
{
    public class Lacos
    {
        public static void Main(string[] args)
        {
            // Laços Iterativos => estruturas que repetem um bloco de código, determinado números de vezes

            // Laço For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("valor de i é " + i);
            }

            // While
            int contador = 3;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Do .. While
            // executa garantida pelo menos uma vez. Execute primeiro e depois testa a condicao.
            double j = 10;
            do 
            {
                Console.WriteLine(j);
                j = j * 1.5;
            }
            while (j < 100);

        // foreach
        // percorre todos os elementos de um conjunto
        int[] conjunto = { 1, 2, 3, 7 };

        foreach(int numero in conjunto)
        {
            Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero + 10));
        }

        }
    }
    }