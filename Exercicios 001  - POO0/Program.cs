using System;

namespace Exercicios_01___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
        
            Console.WriteLine("\t\t\tComparador de numeros \n\n");
            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: \n");
            numero2 = Convert.ToSingle(Console.ReadLine());
           
            for (int x = 0; x < 100; x++)
            {
                Console.Write("_");
            }

            if (numero1 == numero2)
            {
                Console.WriteLine("\nAmbos são iguais\n");
                Console.WriteLine("Os numeros {0} e {1}, são iguais !!!", numero1, numero2);
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("\nO Primeiro numero é maior que o segundo\n");
                Console.WriteLine("{0} é maior que o {1}",numero1,numero2);
            }
            else 
            {
                Console.WriteLine("\nO segundo numero é maior que o primeiro\n");
                Console.WriteLine("{0} é maior que {1}",numero2,numero1);
            }

            for (int x = 0; x < 100; x++)
            {
                Console.Write("_");
            }
            Console.Beep();
            Console.ReadKey();

        }
    }
}
