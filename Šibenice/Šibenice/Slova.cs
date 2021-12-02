using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Šibenice
{
    public class Slova
    {
        public static string ZískejSlovo() { 
        string slova = "kostka,houska,encyklopedie,cyklista,komp,pes";
            List<String> herníSlova = slova.Split(',').ToList();

            short výběrčí = Convert.ToInt16(new Random().Next(herníSlova.Count));
            string vybranéSlovo = herníSlova[výběrčí];
            return vybranéSlovo;
        }
    }
}
