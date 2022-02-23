using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Com_Lista
{
    internal class ListaTelefone
    {
        public Telefone Head { get; set; }
        public Telefone Tail { get; set; }

        public ListaTelefone()
        {
            Head = null;
            Tail = null;
        }

        public bool Vazia()
        {
            return Head == null && Tail == null;
        }
        public void Push(Telefone aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
        }
        public void print()
        {
            if (Vazia())
            {
                Console.WriteLine("\n----------------Agenda vazia -----------------\n");
            }
            else
            {
                Telefone aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.ReadKey();
                } while (aux != null);
          
            }
        }
      
    }
}
