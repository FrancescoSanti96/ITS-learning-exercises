using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Cavallo : Pezzo
    {
        public Cavallo(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            throw new NotImplementedException();
        }
    }
}
