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
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t\t-----Menu-----");
                Console.WriteLine("\n\n\t\t0 - Sair");
                Console.WriteLine("\n\t\t1 - Adicionar Aluno");
                Console.WriteLine("\n\t\t2 - Listar");
                Console.WriteLine("\n\t\t3 - Remover Aluno");
                Console.WriteLine("\n\t\t4 - Aprovados e Reprovados");
                Console.Write("\n\t\tEntre com a opção desejada: ");
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

                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\t\t\tCadastrar Aluno");
                            Console.Write("\n\n\t\tEntre com o nome do Aluno: ");
                            nome = Console.ReadLine();
                            Console.Write("\n\t\tEntre com o Ra do aluno: ");
                            ra = Console.ReadLine();
                            Console.Write("\n\t\tEntre com a Idade: ");
                            idade = int.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaB1: ");
                            nota1 = float.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaB2: ");
                            nota2 = float.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaPIM: ");
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

                            Console.WriteLine("\n\t\tMedia: " + media);

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

                            switch (menu)
                            {
                                case 0://Voltar ao Menu Anterios
                                    {                                       
                                    }break;

                                case 1:// Listar Aprovados
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\t\t\t\tLista de Aprovados");
                                        
                                        for (int x =0; x<quantidade; x++)
                                        {
                                            if (aluno[x] != null)
                                            {
                                                aluno[x].Aprovados();
                                            }
                                            
                                        }
                                        Console.ReadKey();
                                    }break;

                                case 2://Listar Repovados
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\t\t\t\tLista de Reprovados");
                                        for (int x =0; x<=quantidade; x++) 
                                        {
                                            if (aluno[x] != null)
                                            {
                                                aluno[x].Reprovados();
                                            }
                                        }
                                        Console.ReadKey();
                                    }
                                    break;

                                case 3://Listar por Notas
                                    {


                                    }break;

                                default:
                                    {
                                        Console.WriteLine("\n\t\tComando digitado invalido........ Tente novamente!");
                                    }break;

                            }


                        }
                        break;
                    case 3://Remover
                        {                            
                            int raaux;
                            Console.Clear();
                            Console.WriteLine("***Remover***");
                            Console.WriteLine("Entre com o RA do aluno para remover: ");
                            raaux = int.Parse(Console.ReadLine());
                            
                            for (int x = 0; x < quantidade; x++)
                            {
                                if (raaux.Equals(aluno[x].ra) && aluno[x].ativo == true)
                                {
                                    Console.WriteLine("\n\n\t\tRa: " + aluno[x].ra);
                                    Console.WriteLine("\n\t\tNome: " + aluno[x].nome);
                                    Console.WriteLine("\n\t\tIdade: " + aluno[x].idade);
                                    Console.WriteLine("\n\t\tNota B1: " + aluno[x].nota1);
                                    Console.WriteLine("\n\t\tNota B2: " + aluno[x].nota2);
                                    Console.WriteLine("\n\t\tNota Pim: " + aluno[x].notaPim);
                                    Console.WriteLine("\n\t\tMedia: " + aluno[x].media);
                                    Console.WriteLine("\n\n\t\tAprovado: " + aluno[x].aprovado);
                                    aluno[x].ativo = false;
                                }
                              
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
