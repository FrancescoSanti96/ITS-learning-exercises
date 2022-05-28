using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Re : Pezzo
    {
        public Re(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            throw new NotImplementedException();
        }
    }
}
