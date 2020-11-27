using System;

namespace Sistemas_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            // - string Nome
            // - float Preco
            // - bool Promocao (se está em promoção ou não)

            // O sistema deverá ter as seguintes funçoes:

            // - CadastrarProduto
            // - ListarProdutos
            //  - MostrarMenu
            string[] nome = new string[10];
            float[] preco = new float[10];
            string[] promo1 = new string[10];
            Console.Clear();
            Console.WriteLine("Sistema de produtos");

            int opcao;
            int contador = 0; 
            bool promocao;

            do
            {   
                Console.WriteLine("Menu");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar produtos");
                Console.WriteLine("[2] - Listar produtos cadastrados");
                Console.WriteLine("[3] - Mostrar menu");
                Console.WriteLine("[4] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        //Cadastrar produtos
                        string resposta;
                        do
                        {   
                            if (contador < 10)
                            {
                                Console.WriteLine($"Digite o nome do produto {contador+1}");
                                nome[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite o preço do produto {contador+1}");
                                preco[contador] = float.Parse(Console.ReadLine());
                                Console.WriteLine($"O produto {contador+1} está em promoção [s] ou [n] ?");
                                promo1[contador] = Console.ReadLine();
                                contador++;
                            }else{
                                Console.WriteLine("Limite de produto atingido");
                            }

                            Console.WriteLine("Gostaria de cadastrar mais produtos? s/n ?");
                            resposta = Console.ReadLine();
                        } while (resposta == "s");

                        break;


                    case 2:
                        //Listar produtos
                        for (var i = 0; i < contador ; i++)
                        {
                            Console.WriteLine($"Produto: {nome[i]}");
                            Console.WriteLine($"Preço do produto R${preco[i]}");
                            promocao = Promocoes(promo1[i]);
                            Console.WriteLine("-------------------");
                        }
                        break;

                    case 3:
                        //mostrar menu
                        Console.WriteLine("Você já esta no menu!");
                        break;
                    case 4:
                        //sair
                        Console.WriteLine("Obrigado por utilizar nossa aplicação");
                        break;

                    default:
                        Console.WriteLine("Essa opção é invalida");
                        break;
                }
                
            } while (opcao != 4);


            //Minha função
            bool Promocoes(string promo){
                if (promo == "s")
                {
                    Console.WriteLine("O Produto esta em promoção");
                    return true;
                }
                else
                {
                    Console.WriteLine("O produto nao esta em promoção");
                    return false;
                }
            } 
        }
    }
}
