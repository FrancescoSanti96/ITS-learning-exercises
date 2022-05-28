using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSTIC20.Classes
{
    public abstract class Pezzo
    {
        public bool Bianco { get; private set; }
        public Pezzo(bool bianco)
        {
            Bianco = bianco;
        }

        public bool Muovi(Cella partenza, Cella arrivo)
        {
            IEnumerable<Cella> cellePossibili = CalcolaMosseDisponibili(partenza);
            return cellePossibili.Contains(arrivo);
        }

        public abstract IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza);
    }
}
