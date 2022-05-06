using Mestint_beadando_FP.AllapotTer;
using System.Collections.Generic;

namespace Mestint_beadando_FP.Keresok
{
    internal class Melysegi : Kereso
    {
        public override void Keres()
        {
            Stack<Csomopont> nyiltcsucsok = new Stack<Csomopont>();
            List<Csomopont> zartcsucsok = new List<Csomopont>();

            nyiltcsucsok.Push(new Csomopont(new Allapot(), null));

            while (nyiltcsucsok.Count > 0 && !nyiltcsucsok.Peek().Allapot.CelFeltetel())
            {
                Csomopont aktualisCsomopont = nyiltcsucsok.Pop();

                foreach (Operator o in Operatorok)
                {
                    if (o.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = o.Alkalmaz(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont);

                        if (!nyiltcsucsok.Contains(ujCsomopont) && !zartcsucsok.Contains(ujCsomopont))
                        {
                            nyiltcsucsok.Push(ujCsomopont);
                        }
                    }
                }
                zartcsucsok.Add(aktualisCsomopont);
            }
            if (nyiltcsucsok.Count > 0)
            {
                for (Csomopont cs = nyiltcsucsok.Peek(); cs != null; cs = cs.Szulo)
                {
                    Utvonal.Add(cs.Allapot);

                }
                Utvonal.Reverse();
            }


        }
    }
}
