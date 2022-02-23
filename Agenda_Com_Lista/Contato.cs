using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Com_Lista
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public ListaTelefone Telefones { get; set; }
        public Contato Proximo { get; set; }

        public Contato(string nome, string email, ListaTelefone telefones)
        {
            Nome = nome;
            Email = email;
            Telefones = telefones;
            Proximo = null;
        }
        public override string ToString()
        {
            return "\n Nome: " + Nome + "\n Email: " + Email + " ";
        }
    }
}
