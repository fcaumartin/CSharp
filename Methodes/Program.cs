using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    class Program
    {
        //static int fact (int nb)
        //{
        //    int resultat = 1;
        //    for (int i = 2; i <= nb; i++)
        //    {
        //        resultat = resultat * i;
        //    }
        //    return resultat;
        //}

        static int fact(int nb)
        {
            if (nb == 0)
                return 1;
            else
                return nb * fact(nb - 1);
        }

        static string StringToken(string chaine, string sep, int pos)
        {
            int compteur = 0;
            string resultat = "";

            for (int i = 0; i < chaine.Length; i++)
            {
                if (chaine.Substring(i, 1) == sep)
                {
                    compteur++;
                }
                else {
                    if(compteur == pos)
                    {
                        resultat += chaine.Substring(i, 1);
                    }
                }
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            //int r = fact(4);
            //Console.WriteLine(r);


            string r = StringToken("12/07/2016", "/", 0);
            Console.WriteLine(r);


            //StringToken("Toto;Titi;Tutu", ";", 0);

            //StringToken("fcaumartin@gmail.com", "@", 0);
        }
    }
}
