using System;

namespace Exercicio_003___Alunos_GerenciarNotas
{
    class Alunos
    {
        public String nome, ra;
        public int idade;
        public float nota1, nota2, media, notaPim;
        public bool aprovado;
        public bool ativo;

        public void Aprovados()//Metodo para Listar os Aprovados
        {
            if (aprovado == true && ativo == true)
            {
                Console.WriteLine("\n\n\t\tRa: " +ra);
                Console.WriteLine("\n\t\tNome: " + nome);
                Console.WriteLine("\n\t\tIdade: " + idade);
                Console.WriteLine("\n\t\tNota B1: " + nota1);
                Console.WriteLine("\n\t\tNota B2: " + nota2);
                Console.WriteLine("\n\t\tNota Pim: " + notaPim);
                Console.WriteLine("\n\t\tMedia: " + media);
                Console.WriteLine("\n\n\t\tAprovado: " + aprovado);
            }
        }

        public void Reprovados()//Metodo para Listar os Reprovados
        {
            if (aprovado == false && ativo == true)
            {
                Console.WriteLine("\n\n\t\tRa: " + ra);
                Console.WriteLine("\n\t\tNome: " + nome);
                Console.WriteLine("\n\t\tIdade: " + idade);
                Console.WriteLine("\n\t\tNota B1: " + nota1);
                Console.WriteLine("\n\t\tNota B2: " + nota2);
                Console.WriteLine("\n\t\tNota Pim: " + notaPim);
                Console.WriteLine("\n\t\tMedia: " + media);
                Console.WriteLine("\n\n\t\tAprovado: " + aprovado);
            }
        }
    }
}
