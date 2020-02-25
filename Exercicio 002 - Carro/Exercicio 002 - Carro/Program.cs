using System;

namespace Exercicio_002___Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[20];

            int op;
            int quantidade = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\t\tControle de Carros");
                Console.WriteLine("\n\n\n\t\t0 - Sair");
                Console.WriteLine("\n\t\t1 - Incluir");
                Console.WriteLine("\n\t\t2 - Listar");
                Console.WriteLine("\n\t\t3 - Remover");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0://Sair
                        {
                        
                            Console.WriteLine("Adeus.....Precione qualquer tecla para sair");
                            Console.ReadKey();
                        
                        }break;

                    case 1://Inclur
                        {
                            String marca, modelo, cor;
                            int anoFabricacao;
                            char unicoDono;

                            Console.Clear();
                            Console.WriteLine("\n\n\t\t\t\tIncluir Carro");
                            Console.Write("\n\n\n\t\tEntre com a Marca: ");
                            marca = Console.ReadLine();
                            Console.Write("\n\t\tEntre com a Modelo: ");
                            modelo = Console.ReadLine();
                            Console.Write("\n\t\tEntre com a ano de fabricação: ");
                            anoFabricacao = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\n\t\tEntre com a cor: ");
                            cor = Console.ReadLine();
                            Console.Write("\n\t\tÉ o unico dono s/n?: ");
                            unicoDono = Convert.ToChar(Console.ReadLine());
                            
                            //Criando Objeto auxiliar
                            Carro carro = new Carro();

                            if (unicoDono.Equals('s'))//Adicionando Verdade se for unico dono
                            {
                                carro.unicoDono = true;
                            }
                            else
                            {
                                carro.unicoDono = false;
                            }
                                                     
                            carro.marca = marca;
                            carro.modelo = modelo;
                            carro.anoFabriacao = anoFabricacao;
                            carro.cor = cor;
                            
                            carros[quantidade] = carro;// Adicionando os dados no Array
                            quantidade++;

                        }break;

                    case 2://Listar
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t\t\t\tListar carros cadastrados");

                            for (int x = 0; x < quantidade; x++)
                            {
                                                               
                                Console.WriteLine("\n\t\t ID: " + x);
                                Console.WriteLine("\n\t\t Marca: " + carros[x].marca);
                                Console.WriteLine("\t\t Modelo: " + carros[x].modelo);
                                Console.WriteLine("\t\t Ano de Facricação: " + carros[x].anoFabriacao);
                                Console.WriteLine("\t\t Cor: " + carros[x].cor);
                                Console.WriteLine("\t\t Unido Dono: " + carros[x].unicoDono);

                            }
                            Console.ReadKey();

                        }break;

                    case 3://Remover
                        {
                            int idaux;
                            int aux;

                            Console.Clear();
                            Console.WriteLine("\n\n\t\t\t\tRemover veiculo");
                            Console.Write("\n\t\tEntre com o ID: ");
                            idaux = int.Parse(Console.ReadLine());

                            for (int x = idaux; x < quantidade; x++)
                            {
                                if (idaux == x )
                                {
                                    Console.WriteLine("\n\t\t ID: " + x);
                                    Console.WriteLine("\n\t\t Marca: " + carros[x].marca);
                                    Console.WriteLine("\t\t Modelo: " + carros[x].modelo);
                                    Console.WriteLine("\t\t Ano de Facricação: " + carros[x].anoFabriacao);
                                    Console.WriteLine("\t\t Cor: " + carros[x].cor);
                                    Console.WriteLine("\t\t Unido Dono: " + carros[x].unicoDono);

                                }
                                else
                                {
                                    aux = x + 1;
                                    carros[x] = carros[aux];
                                }
                            }

                            quantidade = quantidade - 1;
                            Console.WriteLine("\n\tCarro removido com sucesso, pressione qualquer tecla para continuar");
                            Console.ReadKey();


                        }break;

                    default:
                        {

                            Console.WriteLine("Opção inválida, precisone qualquer tecla para retornar ao menu ");
                            Console.ReadKey();
                        }break;

                }
            } while (op != 0);

        }
    }
}
