using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Alfiere : Pezzo
    {
        public Alfiere(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            throw new NotImplementedException();
        }
    }
}
