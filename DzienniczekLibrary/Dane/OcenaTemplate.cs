using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public class OcenaTemplate
    {
        /// <summary>
        /// Wartosc do wyswietlenia np. 5+ , 2- itd.
        /// </summary>
        public string Ocena { get; set; }
        /// <summary>
        /// Wartosc do obliczania sredniej np. 3+ to 3,5 itd.
        /// </summary>
        public double WartoscDoSredniej { 
            get{
                    double w = Ocena[0] - '0';
                    if (Ocena.Length > 1)
                    {
                        if (Ocena[1] == '+')
                        {
                            w += 0.5;
                        }
                        else
                        {
                            w -= 0.25;
                        }
                    }
                    return w;
                }
            }
        public short Waga { get; set; }
        public string Opis { get; set; }
        public int Id_przedmiotu { get; set; }
        public int Id_ucznia { get; set; }



    }
}
