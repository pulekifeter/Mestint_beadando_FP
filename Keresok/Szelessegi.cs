using Mestint_beadando_FP.AllapotTer;
using System.Collections.Generic;

namespace Mestint_beadando_FP.Keresok
{
    public class Szelessegi : Kereso
    {

        public override void Keres()
        {
            Queue<Csomopont> nyiltcsucsok = new Queue<Csomopont>();
            List<Csomopont> zartcsucsok = new List<Csomopont>();

            nyiltcsucsok.Enqueue(new Csomopont(new Allapot(), null));

            while (nyiltcsucsok.Count > 0 && !nyiltcsucsok.Peek().Allapot.CelFeltetel())
            {
                Csomopont aktualisCsomopont = nyiltcsucsok.Dequeue();

                foreach (Operator o in Operatorok)
                {
                    if (o.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = o.Alkalmaz(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont);

                        if (!nyiltcsucsok.Contains(ujCsomopont) && !zartcsucsok.Contains(ujCsomopont))
                        {
                            nyiltcsucsok.Enqueue(ujCsomopont);
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
