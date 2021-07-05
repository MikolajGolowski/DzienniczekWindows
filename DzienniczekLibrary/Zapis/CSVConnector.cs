using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public class CSVConnector : IDataConnection
    {
        public void DodajOcene(OcenaTemplate ocena)
        {
            throw new NotImplementedException();
        }

        public List<OcenaTemplate> PobierzOcenyUcznia(int id_ucznia, int id_przedmiotu)
        {
            throw new NotImplementedException();
        }

        public List<PrzedmiotTemplate> PobierzPrzedmioty()
        {
            throw new NotImplementedException();
        }

        public List<PrzedmiotTemplate> PobierzPrzedmiotyZKlasy(int id_klasy)
        {
            throw new NotImplementedException();
        }

        public List<UczenTemplate> PobierzUczniowBezOcen()
        {
            throw new NotImplementedException();
        }

        public List<UczenTemplate> PobierzUczniowZKlasy(int id_klasy)
        {
            throw new NotImplementedException();
        }

        public List<Klasa> PobierzWszystkieKlasy()
        {
            throw new NotImplementedException();
        }

        public Klasa StworzKlase(Klasa klasa)
        {
            throw new NotImplementedException();
        }

        public PrzedmiotTemplate StworzPrzedmiot(PrzedmiotTemplate Model)
        {
            Model.Id = 1;
            return Model;
        }

        public void StworzRelacjePrzedmiotKlasa(int id_klasy, int id_przedmiotu)
        {
            throw new NotImplementedException();
        }

        public void StworzRelacjeUczenKlasa(int id_klasy, int id_ucznia)
        {
            throw new NotImplementedException();
        }

        public UczenTemplate StworzUcznia(UczenTemplate Model)
        {
            Model.Id = 1;
            return Model;
        }
    }
}
