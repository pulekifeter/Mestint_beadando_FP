namespace Mestint_beadando_FP.AllapotTer
{
    public class Csomopont
    {
        public Allapot Allapot { get; set; }

        public Csomopont Szulo { get; set; }

        public int Koltseg { get; private set; }

        public int OperatorIndex { get; set; }

        public Csomopont(Allapot allapot, Csomopont szulo)
        {
            this.Allapot = allapot;
            this.Szulo = szulo;
            this.Koltseg = szulo == null ? 0 : szulo.Koltseg + 1;

        }



    }
}