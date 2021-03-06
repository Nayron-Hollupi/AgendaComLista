using System;

namespace Agenda_Com_Lista
{
    internal class ListaContato
    {



        public ListaContato()
        {
        }

        public bool vazia()
        {
                return true;
            else
                return false;
        }


        public void push(Contato aux)
        {
            if (vazia())
            {
                Head = Tail = aux;
            }
            //Quando um objeto entra pelo TAIL
            else if (aux.Nome.CompareTo(Tail.Nome) == 1 || aux.Nome.CompareTo(Tail.Nome) == 0)
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
            // Quando um objeto entra pelo HEAD
            else if (aux.Nome.CompareTo(Head.Nome) == -1 || aux.Nome.CompareTo(Head.Nome) == 0)
            {
                aux.Proximo = Head;
                Head = aux;
            }
            else
            {
                Contato aux1 = Head;
                Contato aux2 = Head;
                aux1 = aux1.Proximo;
                do
                {
                    //Adiciona numero igual ordenado
                    if (aux.Nome.CompareTo(aux1.Nome) == 0)
                    {
                        //mover
                        aux2 = aux1;
                        aux1 = aux1.Proximo;
                        // encadear
                        aux2.Proximo = aux;
                        aux.Proximo = aux1;
                        break;
                    }
                    //Adiciona no meio
                    else if (aux.Nome.CompareTo(aux2.Nome) == 1 && aux.Nome.CompareTo(aux1.Nome) == -1)
                    {
                        aux2.Proximo = aux;
                        aux.Proximo = aux1;
                        break;
                    }
                    aux2 = aux1;
                    aux1 = aux1.Proximo;
                } while (aux1 != null);
            }
        }


            public void pop(string nome)
        {
            if (vazia())
            {
                Console.WriteLine("\n-----Agenda vazia ------\n");
            }
            else
            {
                bool erro = true;
                do
                {
                    if (aux1.Nome == nome)
                    {

                      
                        }
                        else if (aux2.Nome.CompareTo(nome) == -1)
                        {
                            aux2.Proximo = aux1.Proximo;
                            aux2 = aux1.Proximo;

                        }

                        aux1 = null;
                        erro = false;
                    }
                    else
                    {
                        aux2 = aux1;
                        aux1 = aux1.Proximo;
                    }

                } while (aux1 != null);

                if (erro == true)
                    Console.WriteLine("\n-------------Contato não existe---------------\n");
            }


        }

        public void print()
        {
            if (vazia())
            {
                Console.WriteLine("\n-----Agenda vazia ------\n");
            }
            else
            {

                {
                    do
                    {
                        Console.WriteLine(aux.ToString());
                        do
                        {
                            Console.WriteLine(telefone.ToString());
                            telefone = telefone.Proximo;
                        } while (telefone != null);
                        aux = aux.Proximo;
                        Console.ReadKey();

                    } while (aux != null);
                }
                else
                {
                    Console.WriteLine("----------------Contato vazia-------------\n");
                }

            }
        }



        public void pesquisar()
        {
            if (vazia())
            {
                Console.WriteLine("\n-----Agenda vazia ------\n");
            }
            else
            {

                Console.WriteLine("-----------Pesquisar um contato por nome-----------");
                Console.Write("\nDigite o nome que deseja pesquisar: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();


                bool erro = true;
                do
                {
                    if (aux.Nome == nome)
                    {

                        Console.WriteLine(aux.ToString());
                        do
                        {
                            Console.WriteLine(aux_telefone.ToString());
                            aux_telefone = aux_telefone.Proximo;
                        } while (aux_telefone != null);
                        erro = false;
                    }

                    aux = aux.Proximo;

                } while (aux != null);

                if (erro == true)
                    Console.WriteLine("\n-------------Contato não existe---------------\n");
            }

        }


        public void editar()
        {
            if (vazia())
            {
                Console.WriteLine("\n-----Agenda vazia ------\n");
            }
            else
            {
                Console.WriteLine("\n-----------Editar contato:-----------");
                Console.Write("\nDigite o nome que deseja editar: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();

                bool erro = true;
                do
                {
                    if (aux.Nome == nome)
                    {

                        Console.WriteLine(aux.ToString());
                        do
                        {
                            Console.WriteLine(aux_telefone.ToString());
                            aux_telefone = aux_telefone.Proximo;

                        } while (aux_telefone != null);

                        Console.WriteLine("------------------O que deseja Editar?-------------");
                        Console.WriteLine(" 1 - Para nome");
                        Console.WriteLine(" 2 - Para email");
                        Console.WriteLine(" 3 - Para Telefones");

                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.Write("Digite o novo nome: ");
                                nome = Console.ReadLine();
                                nome = nome.ToUpper();
                                pop(aux.Nome);
                                break;
                            case "2":
                                Console.Write("Digite o novo email: ");
                                aux.Email = Console.ReadLine();

                                break;
                            case "3":

                                Console.WriteLine("\n-----------Editar contato:-----------");
                                Console.Write("\nDigite o Tipo que deseja editar: ");
                                string tipo = Console.ReadLine();
                                tipo = tipo.ToUpper();



                                Console.WriteLine(aux.ToString());
                                do
                                {
                                    if (aux_telefone.Tipo == tipo)
                                    {

                                        Console.WriteLine("--------------Digite o que quer  editar " + tipo + " -------------");
                                        Console.WriteLine(" 1 - Para Tipo");
                                        Console.WriteLine(" 2 - Para DDD");
                                        Console.WriteLine(" 3 - Para Numero ");

                                        string op = Console.ReadLine();
                                        switch (op)
                                        {
                                            case "1":
                                                Console.Write("Digite o novo Tipo: ");
                                                aux_telefone.Tipo = Console.ReadLine().ToUpper();
                                                break;
                                            case "2":

                                                Console.Write("Digite o novo DDD: ");
                                                aux_telefone.DDD = int.Parse(Console.ReadLine());
                                                break;
                                            case "3":

                                                Console.Write("Digite o novo Numero: ");
                                                aux_telefone.Numero = int.Parse(Console.ReadLine());
                                                break;

                                            default:
                                                Console.WriteLine("----Opção invalidda");
                                                break;
                                        }

                                    }

                                    aux_telefone = aux_telefone.Proximo;

                                } while (aux_telefone != null);

                                break;
                            default:
                                break;


                        }

                        erro = false;

                    }

                    aux = aux.Proximo;

                } while (aux != null);

                if (erro == true)
                    Console.WriteLine("\n-------------Contato não existe---------------\n");
            }
        }
    }
}



