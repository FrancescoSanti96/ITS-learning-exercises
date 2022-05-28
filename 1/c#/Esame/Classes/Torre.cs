using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Torre : Pezzo
    {
        public Torre(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            throw new NotImplementedException();
        }
    }
}
