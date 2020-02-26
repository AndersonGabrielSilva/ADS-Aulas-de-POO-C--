using System;

namespace Exercicio_003___Alunos_GerenciarNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] aluno = new Alunos[50];
            int quantidade = 0;
            int op;
            do
            {
                Console.WriteLine("***Menu***");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar Aluno");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Remover Aluno");
                Console.WriteLine("4 - Aprovados e Reprovados");
                Console.WriteLine("\nEntre com a opção desejada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0://Sair
                        {
                            Console.WriteLine("Adeus..... Pressione qualquer tecla para sair");
                            Console.ReadKey();
                        }
                        break;
                    case 1://Incluir
                        {
                            String nome;
                            String ra;
                            int idade;
                            float nota1, nota2, notaPim;
                            float media;

                            Console.WriteLine("Entre com o nome do Aluno: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Entre com o Ra do aluno: ");
                            ra = Console.ReadLine();
                            Console.WriteLine("Entre com a Idade: ");
                            idade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com a primeira nota: ");
                            nota1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com a segunda nota: ");
                            nota2 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Entre com a segunda nota do PIM: ");
                            notaPim = float.Parse(Console.ReadLine());

                            media = ((nota1 * 4) + (notaPim * 2) + (nota2 * 4)) / 10;
                            Alunos cadastroaluno = new Alunos();

                            if (media > 5)
                            {
                                cadastroaluno.aprovado = true;
                            }
                            else
                            {
                                cadastroaluno.aprovado = false;
                            }

                            cadastroaluno.nome = nome;
                            cadastroaluno.ra = ra;
                            cadastroaluno.idade = idade;
                            cadastroaluno.nota1 = nota1;
                            cadastroaluno.nota2 = nota2;
                            cadastroaluno.media = media;
                            cadastroaluno.notaPim = notaPim;
                            cadastroaluno.ativo = true;

                            aluno[quantidade] = cadastroaluno;
                            quantidade++;
                        }
                        break;
                    case 2:// Listar
                        {
                            int menu;
                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\t\t\tListar Alunos");
                            Console.WriteLine("\n\t\t0 - Voltar ao menu anterior");
                            Console.WriteLine("\n\t\t1 - Lista de Aprovados");
                            Console.WriteLine("\n\t\t2 - Lista de Reprovados");
                            Console.WriteLine("\n\t\t3 - Listar por Nota ");
                            menu = int.Parse(Console.ReadLine());


                        }
                        break;
                    case 3://Remover
                        {
                            Console.Clear();
                            int raaux;
                            Console.WriteLine("***Remover***");
                            Console.WriteLine("Entre com o RA do aluno para remover: ");
                            raaux = int.Parse(Console.ReadLine());
                            int aux;
                            for (int x = raaux; x < quantidade; x++)
                            {
                                aux = x + 1;
                                aluno[x] = aluno[aux];

                            }
                            quantidade = quantidade - 1;
                            Console.WriteLine("Removido, pressione qualquer tecla para continuar");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Lista de Aprovados!!!");

                            for (int y = 0; y <= quantidade; y++)
                            {
                                if (aluno[y].aprovado == true)
                                {
                                    Console.WriteLine("{0}\t{1}\t Aprovado", aluno[y].nome, aluno[y].media);
                                }
                            }

                        }
                        break;
                }
            } while (op != 0);
        }

     
    }
}
