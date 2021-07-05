using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public interface IDataConnection
    {
        PrzedmiotTemplate StworzPrzedmiot(PrzedmiotTemplate Model);
        UczenTemplate StworzUcznia(UczenTemplate Model);
        List<UczenTemplate> PobierzUczniowBezOcen();
        List<PrzedmiotTemplate> PobierzPrzedmioty();
        Klasa StworzKlase(Klasa klasa);
        void StworzRelacjeUczenKlasa(int id_klasy, int id_ucznia);
        void StworzRelacjePrzedmiotKlasa(int id_klasy, int id_przedmiotu);
        List<Klasa> PobierzWszystkieKlasy();
        List<PrzedmiotTemplate> PobierzPrzedmiotyZKlasy(int id_klasy);
        List<UczenTemplate> PobierzUczniowZKlasy(int id_klasy);
        List<OcenaTemplate> PobierzOcenyUcznia(int id_ucznia, int id_przedmiotu);
        void DodajOcene(OcenaTemplate ocena);
    }
}
