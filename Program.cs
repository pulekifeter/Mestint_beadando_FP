using System;
using Mestint_beadando_FP.AllapotTer;
using Mestint_beadando_FP.Keresok;

namespace Mestint_beadando_FP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine(" 1- Mélységi \n 2- Szélességi \n 3- Backtrack \n 4-Optimális");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            
          
            switch(a)
                {
                    case 1:
                        Kereso keres = new Keresok.Melysegi();
                        keres.Keres();
                        foreach (var allapot in keres.Utvonal)
                        {
                            Console.WriteLine(allapot);
                        }                     
                        break;
                    case 2:
                        Kereso keres1 = new Szelessegi();
                        keres1.Keres();
                        foreach (var allapot in keres1.Utvonal)
                        {
                            Console.WriteLine(allapot);
                        }
                        break;
                    case 3:
                        Kereso keres2 = new Keresok.Backtrack();
                        keres2.Keres();
                        foreach (var allapot in keres2.Utvonal)
                        {
                            Console.WriteLine(allapot);
                        }
                        break;
                case 4:
                    Kereso keres3 = new Keresok.Optimalis();
                    keres3.Keres();
                    for (int i = 0; i < keres3.Utvonal.Count/2; i++)
                    {
                        Console.WriteLine(keres3.Utvonal[i]);
                    }
                    break;

            }
            
           
            
            

        }
    }
}
