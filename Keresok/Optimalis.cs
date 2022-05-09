﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mestint_beadando_FP.AllapotTer;

namespace Mestint_beadando_FP.Keresok
{
    class Optimalis : Kereso
    {
        public Optimalis()
        {
            Keres();
        }

        public override void Keres()
        {
            List<Csomopont> ut = new List<Csomopont>();
            ut.Add(new Csomopont(new Allapot(), null));

            while (ut.Count > 0 && !ut.Last().Allapot.CelFeltetel())
            {
                Csomopont aktualisCsomopont = ut.Last();
                ut.RemoveAt(ut.Count - 1);
                foreach (Operator op in Operatorok)
                {
                    if (op.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = op.Alkalmaz(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont);

                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Add(ujCsomopont);
                        }
                        else
                        {
                            int i = ut.IndexOf(ujCsomopont);
                            Csomopont regiCsomopont = ut[i];

                            if (regiCsomopont.Koltseg > ujCsomopont.Koltseg)
                            {
                                ut[i] = ujCsomopont;
                            }
                        }
                    }
                }

                ut.Sort(
                    delegate (Csomopont cs1, Csomopont cs2)
                    {
                        if (cs1.Koltseg > cs2.Koltseg)
                        {
                            return -1;
                        }
                        else if (cs1.Koltseg < cs2.Koltseg)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    });
            }

            if (ut.Count > 0)
            {
                Csomopont celCsomopont = ut.Last();
                while (celCsomopont != null)
                {
                    this.Utvonal.Add(celCsomopont.Allapot);
                    celCsomopont = celCsomopont.Szulo;
                }

                this.Utvonal.Reverse();
            }
        }
    }
}
