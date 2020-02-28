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
                Console.WriteLine("\n\t\t3 - Editar");
                Console.WriteLine("\n\t\t4 - Remover Aluno");
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
                            nome = nome.ToUpper();//Convertedo caracteres para maiuculo 
                            Console.Write("\n\t\tEntre com o Ra do aluno: ");
                            ra = Console.ReadLine();
                            ra = ra.ToUpper();//Convertedo caracteres para maiuculo 
                            Console.Write("\n\t\tEntre com a Idade: ");
                            idade = int.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaB1: ");
                            nota1 = float.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaB2: ");
                            nota2 = float.Parse(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a notaPIM: ");
                            notaPim = float.Parse(Console.ReadLine());                         
                            
                             //Bloco abaixo destinado há calcular a media dos alunos 
                            media = ((nota1 * 4) + (notaPim * 2) + (nota2 * 4)) / 10;
                            Alunos cadastroaluno = new Alunos();

                             //Bloco abaixo destinado há calcular a passar o valor de true ou false de acordo com a media
                             //Aprovado ou Reprovado
                            if (media > 5)
                            {
                                cadastroaluno.aprovado = true;
                            }
                            else
                            {
                                cadastroaluno.aprovado = false;
                            }

                            Console.WriteLine("\n\t\tMedia: " + media);
                            Console.ReadKey();

                            cadastroaluno.nome = nome;
                            cadastroaluno.ra =  ra;
                            cadastroaluno.idade = idade;
                            cadastroaluno.nota1 = nota1;
                            cadastroaluno.nota2 = nota2;
                            cadastroaluno.media = media;
                            cadastroaluno.notaPim = notaPim;
                            cadastroaluno.ativo = true;

                            //Bloco abaixo ultilizado para adicionar os dados ao Objeto principal
                            if (aluno[quantidade] == null)// verifica se a primeira posição é nulo, se sim adiciona na primeira posição
                            {
                                aluno[quantidade] = cadastroaluno;
                                quantidade++;
                            }
                            else//Bloco abaixo verifica se o aluno está ou não ativo, se o aluno estiver inativo ou o local
                                //estiver desoculpado se adiciona no local 
                            {
                                for (int x = 0; x <= quantidade; x++)
                                {
                                    if (aluno[quantidade].ativo != true)
                                    {
                                        aluno[quantidade] = cadastroaluno;
                                        quantidade++;
                                    }
                                }
                            }

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
                                    }
                                    break;

                                case 1:// Listar Aprovados
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\t\t\t\tLista de Aprovados");

                                        for (int x = 0; x <= quantidade; x++)
                                        {
                                            if (aluno[x] != null)
                                            {
                                                aluno[x].Aprovados();
                                            }

                                        }
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2://Listar Repovados
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\t\t\t\tLista de Reprovados");
                                        for (int x = 0; x <= quantidade; x++)
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
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\t\t\t\tOrdenar por notas");

                                        //O Metodo abaixo ordena os array de acordo com as notas, da maior para a menor
                                        OrdenarPorNotas();

                                        for (int x = 0; x <= quantidade; x++)
                                        {
                                            if (aluno[x] != null)
                                            {
                                                aluno[x].Status();
                                            }
                                        }
                                        Console.ReadKey();
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("\n\t\tComando digitado invalido........ Tente novamente!");
                                    }
                                    break;

                            }


                        }
                        break;
                    case 3://Editar
                        {
                            string raEditar;
                            char resposta;
                            int localArray;

                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\t\t\tEditar Aluno");
                            Console.Write("\n\n\t\tEntre com o RA:");
                            raEditar = Console.ReadLine();
                            raEditar = raEditar.ToUpper();//Convertedo caracteres para maiuculo 

                            localArray = PesquisarAluno(raEditar);                           

                            if (localArray != quantidade + 1) {

                                Console.Write("\n\t\tDeseja editar aluno[s/n]? : ");
                                resposta = Convert.ToChar(Console.ReadLine());

                                if (resposta == 's')//Editando Aluno
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\t\t\t\tEditar Aluno");
                                    Console.WriteLine("\n\n\t\tRa: " + aluno[localArray].ra);
                                    Console.Write("\n\n\t\tEntre com o nome do Aluno: ");
                                    aluno[localArray].nome = Console.ReadLine();
                                    aluno[localArray].nome = aluno[localArray].nome.ToUpper();//Convertedo todos caracteres para Maiuculo 
                                    Console.Write("\n\t\tEntre com a Idade: ");
                                    aluno[localArray].idade = int.Parse(Console.ReadLine());
                                    Console.Write("\n\t\tEntre com a notaB1: ");
                                    aluno[localArray].nota1 = float.Parse(Console.ReadLine());
                                    Console.Write("\n\t\tEntre com a notaB2: ");
                                    aluno[localArray].nota2 = float.Parse(Console.ReadLine());
                                    Console.Write("\n\t\tEntre com a notaPIM: ");
                                    aluno[localArray].notaPim = float.Parse(Console.ReadLine());

                                    aluno[localArray].media = ((aluno[localArray].nota1 * 4) + (aluno[localArray].notaPim * 2) + (aluno[localArray].nota2 * 4)) / 10;

                                    if (aluno[localArray].media > 5)
                                    {
                                        aluno[localArray].aprovado = true;
                                    }
                                    else
                                    {
                                        aluno[localArray].aprovado = false;
                                    }

                                    Console.WriteLine("\n\t\tMedia: " + aluno[localArray].media);
                                    Console.WriteLine("\n\t\tAluno Editado");
                                    Console.ReadKey();

                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\n\t\tAluno não encontrado.....");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case 4:// Remover
                        {
                            string raaux;
                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\t\t\t-----Remover-----");
                            Console.WriteLine("\n\n\t\tEntre com o RA do aluno para remover: ");
                            raaux = Console.ReadLine();

                            for (int x = 0; x <= quantidade; x++)
                            {
                                if (aluno[x] != null && raaux.Equals(aluno[x].ra) && aluno[x].ativo == true)
                                {
                                    aluno[x].Status();

                                    //Muda o Status ativo para false, liberando local do vetor para ser reutilizado mais tarde
                                    aluno[x].ativo = false;
                                }

                            }

                            quantidade = quantidade - 1;
                            Console.WriteLine("Removido, pressione qualquer tecla para continuar");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("\n\t\tComando digitado invalido........ Tente novamente!");
                        }
                        break;

                }
            } while (op != 0);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
                /*
                    Bloco destinado há pesquisa de algum aluno 
                    expecifico pelo RA
                */
            int PesquisarAluno(string raPesquisar)
            {
                int aux = quantidade + 1;//Somente para nunca retornar um numero fora do array.

                for (int x = 0; x <= quantidade; x++)
                {
                    if (aluno[x] != null && raPesquisar.Equals(aluno[x].ra) && aluno[x].ativo == true)
                    {
                        aluno[x].Status();
                        aux = x;
                    }
                }
                return (aux);
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
                /*
                    Bloco abaixo destinado há ordenar arrays por ordem de notas 
                    da maior para a menor
                */
            void OrdenarPorNotas()//Ordena por notas
            {
                Alunos alunoAux = new Alunos();//Objeto Auxiliar para ordenar por notas

                for (int x = 0; x <= quantidade; x++)
                {
                    if (aluno[x] != null)
                    {
                        for (int y = 0; y <= quantidade; y++)
                        {
                            if (aluno[y] != null && aluno[y].media < aluno[x].media)
                            {
                                alunoAux = aluno[y];
                                aluno[y] = aluno[x];
                                aluno[x] = alunoAux;
                            }
                        }
                    }
                }
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
