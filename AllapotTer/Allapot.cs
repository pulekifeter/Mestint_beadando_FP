using System.Text;

public class Allapot
{
    public static int KORONGOK_SZAMA = 6;
    public static int[] korongok = new int[] { 1, 2, 3, 4, 5, 6 };
    public int[] mezok = new int[KORONGOK_SZAMA + 1];



    public Allapot()
    {
        #region alaphelyzet
        mezok[0] = 1;
        mezok[1] = 2;
        mezok[2] = 3;
        mezok[3] = 5;
        mezok[4] = 6;
        mezok[5] = 4;
        mezok[6] = 0;
        #endregion
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < mezok.Length; i++)
        {
            sb.Append(mezok[i]);
            sb.Append("\n");
        }
        return sb.ToString();
    }

    public bool CelFeltetel()
    {
        if (mezok[6] != 0) return false;
        int elso_index = 0;

        for (int i = 0; i < mezok.Length; i++)
        {
            if (mezok[i] == 1)
            {
                elso_index = i;
                break;
            }
        }
        int f = 2;
        for (int i = ++elso_index; i < mezok.Length - elso_index; i++)
        {

            if (mezok[i] != f) return false;

            f++;
        }
        if (f == 7) return true;
        for (int i = 0; f < 7; i++)
        {
            if (mezok[i] != f) return false;
            f++;
        }
        return true;

    }

}