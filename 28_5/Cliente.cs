using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_5
{
    internal class Cliente
    {
        public string Username { get; set; }
        private string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Carrello carrello { get; set; }
    }
}
