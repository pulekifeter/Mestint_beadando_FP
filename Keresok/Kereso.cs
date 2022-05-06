using Mestint_beadando_FP.AllapotTer;
using System.Collections.Generic;

namespace Mestint_beadando_FP.Keresok
{
    public abstract class Kereso
    {
        public List<Allapot> Utvonal = new List<Allapot>();
        public List<Operator> Operatorok = new List<Operator>();

        public void OperatorokGeneralasa()
        {
            for (int i = 0; i < Allapot.KORONGOK_SZAMA + 1; i++)
            {
                for (int j = 0; j < Allapot.korongok.Length; j++)
                {
                    Operatorok.Add(new Operator(i, Allapot.korongok[j]));
                }
            }
        }

        public Kereso()
        {
            OperatorokGeneralasa();
        }

        public abstract void Keres();


    }
}
