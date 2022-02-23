using System;
using System.Collections.Generic;

namespace Agenda_Com_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int sair = 1;
            ListaContato contato = new ListaContato();


            string Menu()
            {
                Console.WriteLine("-------------Menu-------------");
                Console.WriteLine(" 1 - Cadastrar Contato");
                Console.WriteLine(" 2 - Imprimir Todos os contatos");
                Console.WriteLine(" 3 - Pesquisar por nome ");
                Console.WriteLine(" 4 - Remover contato ");
                Console.WriteLine(" 5 - Editar contato ");
                Console.WriteLine(" 6 - Sair");

                string opcao = Console.ReadLine();
                return opcao;
            }

            static Contato cadastrar()
            {
                
                ListaTelefone listaTelefone = new ListaTelefone();

                Console.WriteLine("\n---------------Cadastrar um contato-------------------\n");
                Console.Write("Digite o nome do contato: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();

                Console.Write("Digite o email do contato: ");
                string email = Console.ReadLine();


                string novo = "1";
                do
                {
                    Console.Write("Digite o Tipo do contato exemplo Casa , Trabalho, Celular.... : ");
                    string tipo = Console.ReadLine();
                    tipo = tipo.ToUpper();

                    Console.Write("Digite o DDD do contato: ");
                    int ddd = int.Parse(Console.ReadLine());
                    Console.Write("Digite o numero do contato: ");
                    int numero = int.Parse(Console.ReadLine());

                    listaTelefone.Push(new Telefone(tipo, ddd, numero));


                    Console.WriteLine("Para adicionar um novo telefone .  1 - para adicionar e qualquer tecla para sair)");
                    novo = Console.ReadLine();

                } while (novo == "1");

                return new Contato(nome, email, listaTelefone);
            }

            string Remover()
            {
                Console.Write("\n----------Remover por nome-----------");
                Console.Write("\n Digite o nome do contato que deseja remover : ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();

                return nome;
            }

            void Pesquisar()
            {
                Console.Clear();
                contato.pesquisar();

            }


            do
            {
                switch (Menu())
                {

                    case "1":
                        Console.Clear();
                        contato.push(cadastrar());
                        break;
                    case "2":
                        Console.Clear();
                        contato.print();
                        break;
                    case "3":
                        Console.Clear();
                        Pesquisar();
                        break;
                    case "4":
                        contato.pop(Remover());
                        break;
                    case "5":
                        Console.Clear();
                        contato.editar();
                        break;
                    case "6":
                        sair = 0;
                        break;

                    default:
                        Console.WriteLine("\n------------OPS! Opção invelida---------------\n");
                        break;
                }
            } while (sair != 0);



        }

    }


}

