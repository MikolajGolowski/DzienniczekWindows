using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public class UczenTemplate
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
      //  public string NrTelefonu { get; set; } = "nie podano numeru telefonu";
        public string Pesel { get; set; } = "nie podano peselu";
        /// <summary>
        /// lista ocen danego ucznia
        /// </summary>
        public List<OcenaTemplate> Oceny { get; set; } = new List<OcenaTemplate>();

        public int Id { get; set; }


        public UczenTemplate(string imi, string naz, string pes)
        {
            Imie = imi;
            Nazwisko = naz;
            Pesel = pes;
        }

        public string NazwiskoImie
        {
            get
            {
                return $"{Nazwisko} {Imie}";
            }
        }

        public UczenTemplate(System.Int32 id, System.String Imie, System.String Nazwisko, System.Int32 Pesel = 0)
        {
            this.Id = id;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Pesel = Pesel.ToString();
        }
    }
}
