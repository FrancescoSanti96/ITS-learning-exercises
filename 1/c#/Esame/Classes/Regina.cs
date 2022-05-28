using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Regina : Pezzo
    {
        public Regina(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            throw new NotImplementedException();
        }
    }
}
