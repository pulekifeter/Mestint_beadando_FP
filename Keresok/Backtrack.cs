using Mestint_beadando_FP.AllapotTer;
using System.Collections.Generic;
using System.Linq;


namespace Mestint_beadando_FP.Keresok
{
    internal class Backtrack : Kereso
    {
        public override void Keres()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            ut.Push(new Csomopont(new Allapot(), null));

            while (ut.Count > 0 && !ut.Peek().Allapot.CelFeltetel())
            {
                Csomopont aktualisCsomopont = ut.Peek();
                if (aktualisCsomopont.OperatorIndex < Operatorok.Count())
                {
                    Operator aktualisOperator = Operatorok[aktualisCsomopont.OperatorIndex];
                    if (aktualisOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Alkalmaz(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont);

                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Push(ujCsomopont);
                        }

                    }
                    aktualisCsomopont.OperatorIndex++;

                }
                else
                {
                    ut.Pop();
                }
            }

            foreach (Csomopont cs in ut)
            {
                Utvonal.Add(cs.Allapot);
            }
            Utvonal.Reverse();
        }
    }
}
