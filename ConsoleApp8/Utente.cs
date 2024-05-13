using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Utente
    {
        public string Username { get; set; }
        private string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Carrello Carrelli { get; set; }

    }
}
