namespace Mestint_beadando_FP.AllapotTer
{
    public class Operator
    {
        public int Mit { get; private set; }
        public int Melyikre { get; private set; }

        public Operator(int Mit, int Melyikre)
        {
            this.Mit = Mit;
            this.Melyikre = Melyikre;

        }

        public bool EloFeltetel(Allapot allapot)
        {
            if (Mit == Melyikre) return false;
            if (allapot.mezok[Mit] == 0) return false;
            if (allapot.mezok[Melyikre] != 0) return false;

            switch (Mit)
            {
                case 0:
                    if (Melyikre == 5 || Melyikre == 1 || Melyikre == 6) return true;
                    break;
                case 1:
                    if (Melyikre == 0 || Melyikre == 2 || Melyikre == 6) return true;
                    break;
                case 2:
                    if (Melyikre == 1 || Melyikre == 3 || Melyikre == 6) return true;
                    break;
                case 3:
                    if (Melyikre == 2 || Melyikre == 4 || Melyikre == 6) return true;
                    break;
                case 4:
                    if (Melyikre == 3 || Melyikre == 5 || Melyikre == 6) return true;
                    break;
                case 5:
                    if (Melyikre == 4 || Melyikre == 0 || Melyikre == 6) return true;
                    break;
                case 6:
                    if (Melyikre != 6) return true;
                    break;


                default:
                    return false;
            }


            return false;
        }


        public Allapot Alkalmaz(Allapot allapot)
        {

            Allapot ujAllapot = new Allapot();
            for (int i = 0; i < Allapot.KORONGOK_SZAMA + 1; i++)
            {
                ujAllapot.mezok[i] = allapot.mezok[i];

            }

            ujAllapot.mezok[Melyikre] = allapot.mezok[Mit];
            ujAllapot.mezok[Mit] = 0;


            return ujAllapot;
        }


    }
}
