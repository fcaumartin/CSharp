using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    class Program
    {
        static int fact (int nb)
        {
            int resultat = 1;
            for (int i = 1; i <= nb; i++)
            {
                resultat = resultat * i;
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            int r = fact(4);
            Console.WriteLine(r);
        }
    }
}
