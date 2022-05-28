using FITSTIC20.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FITSTIC20
{
    public class TestEsame
    {
        [TestCase("D2", new string[] { "D3","D4" }, typeof(Pedone), true)]
        [TestCase("D3", new string[] { "D4" }, typeof(Pedone), true)]
        [TestCase("G7", new string[] { "G6","G5" }, typeof(Pedone), false)]
        [TestCase("E1", new string[] { "D1", "D2", "E2", "F2", "F1" }, typeof(Re), true)]
        [TestCase("A8", new string[] { "A7", "B8", "B7"}, typeof(Re), true)]
        [TestCase("D4", new string[] { "E6", "F5", "F3", "E2", "C2", "B3","B5","C6" }, typeof(Cavallo), false)]
        [TestCase("D5", new string[] { "D8","D7","D6","D4","D3","D2","D1","A5","B5","C5","E5","F5","G5","H5" }, typeof(Torre), false)]
        [TestCase("D5", new string[] { "E6", "F7", "G8", "C4", "B3", "A2", "H1", "G2", "F3", "E4", "A8", "B7", "C6" }, typeof(Alfiere), false)]
        [TestCase("D5", new string[] { "E6", "F7", "G8", "C4", "B3", "A2", "H1", "G2", "F3", "E4", "A8", "B7", "C6",
                                        "D8","D7","D6","D4","D3","D2","D1","A5","B5","C5","E5","F5","G5","H5"}, typeof(Regina), false)]
        public void TestMosseValida(string cellaPartenza, string[] celleArrivo, Type tipoPezzo, bool bianco)
        {
            Cella partenza = new Cella(cellaPartenza);
            Cella[] arrivi = celleArrivo.OrderBy(x=>x).Select(x => new Cella(x)).ToArray();
            Pezzo p = (Pezzo)Activator.CreateInstance(tipoPezzo, new object[] { bianco });
            var cellePossibili= p.CalcolaMosseDisponibili(partenza).OrderBy(x => x.ToString()).ToArray();
            Assert.AreEqual(arrivi, cellePossibili);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void TestMossaFuoriScacchiera(bool bianco)
        {
            var ts = CaricaPezziTestabili();
            Cella c = new Cella(bianco ? "A8" : "A1");
            foreach (var type in ts)
            {
                Pezzo p = (Pezzo)Activator.CreateInstance(type, new object[] { bianco });
                var cellePossibili = p.CalcolaMosseDisponibili(c).ToList();
                Assert.True(cellePossibili.TrueForAll(cl=>cl.Valida()));
            }
        }

        private IEnumerable<Type> CaricaPezziTestabili()
        {
            return System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(ITest).IsAssignableFrom(type) && 
                typeof(Pezzo).IsAssignableFrom(type))
                .ToList();
        }
    }
}