using System;

namespace FITSTIC20.Classes
{
    public class Cella
    {
        public readonly int NRiga, NColonna;

        public Cella(string codice)
        {
            char colonna = codice[0];
            int riga = int.Parse(codice.Substring(1).ToString());

            NColonna = char.ToUpper(colonna)-'A';
            NRiga = riga;
        }

        public char LetteraColonna()
        {
            return (char)(NColonna + 'A');
        }

        public override bool Equals(object obj)
        {
            return obj is Cella cella && cella != null &&
                   NRiga == cella.NRiga &&
                   NColonna == cella.NColonna;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NRiga, NColonna);
        }

        public override string ToString()
        {
            return LetteraColonna() + "" + NRiga;
        }

        public bool Valida()
        {
            return NRiga > 0 && NRiga <= 8 &&
                NColonna > 0 && NColonna <= 8;
        }
    }
}
