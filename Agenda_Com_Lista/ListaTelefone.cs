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
            Tail = null;
        }

        public bool Vazia()
        {
        }
        public void Push(Telefone aux)
        {
            if (Vazia())
            {
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
            {
                Console.WriteLine("\n----------------Agenda vazia -----------------\n");
            }
            else
            {
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
