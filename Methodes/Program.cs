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

        static void Main(string[] args)
        {
            int r = fact(4);
            Console.WriteLine(r);
        }
    }
}
