using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public class Klasa
    {
        /// <summary>
        /// Wychowawca klasy
        /// </summary>
        public string Wychowawca { get; set; }

        /// <summary>
        /// Lista uczniow w klasie
        /// </summary>
        public List<UczenTemplate> Uczniowie { get; set; } = new List<UczenTemplate>();

        /// <summary>
        /// Rok na ktorym sa czlonkowie danej klasy
        /// </summary>
        public int Rok { get; set; }

        /// <summary>
        /// np. A,B,C...
        /// </summary>
        public string NazwaKlasy { get; set; }

        public List<PrzedmiotTemplate> Przedmioty { get; set; } = new List<PrzedmiotTemplate>();

        public int id;

        public Klasa(Int32 id = 0, string wychowawca = "", string rok = "1", string nazwa_klasy = "")
        {
            this.id = id;
            this.Wychowawca = wychowawca;
            this.Rok = int.Parse(rok);
            this.NazwaKlasy = nazwa_klasy;
        }

        public string DisplayNazwa
        {
            get
            {
                return $"{Rok}{NazwaKlasy}";            //TODO ZROBIC INTERPRETER INTA NA CYFRY RZYMSKIE
            }
        }

    }
}
