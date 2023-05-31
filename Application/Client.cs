using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Client : User
    {
        private bool abonament;
        private DateTime ultimaComanda;
        private bool blocked;

        public Client()
        {

        }

        public Client(bool abonament, DateTime ultimaComanda, bool blocked)
        {
            this.abonament = abonament;
            this.ultimaComanda = ultimaComanda;
            this.blocked = blocked;
        }

        public bool Abonament
        {
            get { return this.abonament; }
            set { this.abonament = value; }
        }

        public DateTime UltimaComanda
        {
            get { return this.ultimaComanda; }
            set { this.ultimaComanda = value; }
        }

        public bool Blocked
        {
            get { return this.blocked; }
            set { this.blocked = value; }
        }
    }
}
