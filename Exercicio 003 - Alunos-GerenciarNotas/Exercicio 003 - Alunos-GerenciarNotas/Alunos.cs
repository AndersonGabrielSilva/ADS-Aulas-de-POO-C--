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

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            
                 //Bloco abaixo destinado há exibir somente os Aprovados        
        public void Aprovados()//Metodo para Listar os Aprovados
        {
            if (aprovado == true && ativo == true)
            {
                Status();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            
                //Bloco abaixo destinado há exibir somente os Reprovados
        public void Reprovados()//Metodo para Listar os Reprovados
        {
            if (aprovado == false && ativo == true)
            {
                Status();
            }
        
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------        
            
                //Bloco abaixo destinado há exibir o Status do objeto        
        public void Status()
        {
            Console.WriteLine("\n\n\t\tRa: " + ra);
            Console.WriteLine("\t\tNome: " + nome);
            Console.WriteLine("\t\tIdade: " + idade);
            Console.WriteLine("\t\tNota B1: " + nota1);
            Console.WriteLine("\t\tNota B2: " + nota2);
            Console.WriteLine("\t\tNota Pim: " + notaPim);
            Console.WriteLine("\t\tMedia: " + media);
            Console.WriteLine("\n\t\tAprovado: " + aprovado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
    }


}

