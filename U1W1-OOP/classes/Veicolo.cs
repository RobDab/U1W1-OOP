using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1W1_OOP
{
    internal class Veicolo
    {
        public string marca = "Tesla";
        private string _modello;

        public string Modello
        {
            get { return _modello; }
            set { _modello = value; }
        }

    }
}
