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
            //Usuario adm tem que ser o mesmo que a senha
            //quando abrir vai aparecer o menu 
            //cadastrar o usuario novos
            //MENU DE CADASTRO 
            //MENU DE ADM
            string[] nome = new string[10];
            float[] preco = new float[10];
            string[] promo1 = new string[10];
            Console.Clear();
            Console.WriteLine("Sistema de produtos");
            int opcao;
            int contador = 0; 
            bool promocao;
            int login;
            bool loginADM;
            bool senhaADM;

            do
            {   
                Console.WriteLine("Realizar loguin");
                Console.WriteLine("[1] Sou o Adiministrador");
                Console.WriteLine("[2] Sou funcionario");
                login = int.Parse(Console.ReadLine());

                switch (login)
                {
                    case 1:
                        //LOGIN DO ADM
                            do
                            {
                                Console.WriteLine("Digite o login de administrador");
                                string logindeadm = Console.ReadLine();
                                loginADM = Loginadmf(logindeadm);
                            
                            } while (!loginADM);
                        //SENHA DO ADM
                            do
                            {
                                Console.WriteLine("Digite agora a senha de administrador");
                                string senhadoadm = Console.ReadLine();
                                senhaADM = Senhaadmf(senhadoadm);
                            
                            } while (!senhaADM);

                        //MENU DO ADM
                            do
                            {
                                Console.WriteLine("MENU do Adiministrador");
                                Console.WriteLine("[1] Cadastrar um novo usurio");
                                Console.WriteLine("[2] Ver usuarios cadastrados");

                            } while (false);
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
                
            } while (false);





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
                        Console.WriteLine("Essa opção é invalida!");
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

            bool Loginadmf(string loginadm){

                if (loginadm == "adm")
                {
                    return true;
                }
                else{
                    Console.WriteLine("Login de administrador errado");
                    return false;
                }
            }

            bool Senhaadmf(string senhaadm){

                if (senhaadm == "12345")
                {
                    return true;
                }
                else{
                    Console.WriteLine("Senha de administrador errada");
                    return false;
                }
            }

        }
    }
}
