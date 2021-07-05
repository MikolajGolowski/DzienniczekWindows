using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public class PrzedmiotTemplate
    {
        public string Nazwa { get; set; }
        public string Nauczyciel { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// Template przedmiotu z id = 0.
        /// </summary>
        /// <param name="naz">Nazwa przedmiotu</param>
        /// <param name="nau">Nauczyciel przedmiotu</param>
        public PrzedmiotTemplate(string naz, string nau)
        {
            Nazwa = naz;
            Nauczyciel = nau;
            Id = 0;
        }

        public PrzedmiotTemplate(System.Int32 id, System.String Nazwa, System.String Nauczyciel)
        {
            this.Id = id;
            this.Nazwa = Nazwa;
            this.Nauczyciel = Nauczyciel;
        }

        public string NauczycielPrzedmiot
        {
            get
            {
                return $"{Nauczyciel}, {Nazwa}";
            }
        }
    }
}
