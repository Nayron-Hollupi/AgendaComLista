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
            HEAD = null;
            Tail = null;
        }

        public bool Vazia()
        {
            return HEAD == null && Tail == null;
        }
        public void Push(Telefone aux)
        {
            if (Vazia())
            {
                HEAD = aux;
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
            if (vazia())
            {
                Console.WriteLine("\n----------------Agenda vazia -----------------\n");
            }
            else
            {
                Telefone aux = HEAD;
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
