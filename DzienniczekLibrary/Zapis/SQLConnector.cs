using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace DzienniczekLibrary
{
    public class SQLConnector : IDataConnection
    {
        private const string NazwaBazy = "DzienniczekDB";

        public void DodajOcene(OcenaTemplate ocena)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id_ucznia", ocena.Id_ucznia);
                p.Add("@id_przedmiotu", ocena.Id_przedmiotu);
                p.Add("@opis", ocena.Opis);
                p.Add("@ocena", ocena.Ocena);
                p.Add("@waga", ocena.Waga);

                connection.Execute("dbo.spDodajOcene", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<OcenaTemplate> PobierzOcenyUcznia(int id_ucznia, int id_przedmiotu)
        {
            List<OcenaTemplate> l = new List<OcenaTemplate>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                DynamicParameters d = new DynamicParameters();
                d.Add("@id_ucznia", id_ucznia);
                d.Add("@id_przedmiotu", id_przedmiotu);

                l = connection.Query<OcenaTemplate>("dbo.spWszystkieOcenyUczniaZPrzedmiotu", d, commandType: CommandType.StoredProcedure).ToList();
            }
            return l;
        }

        public List<PrzedmiotTemplate> PobierzPrzedmioty()
        {
            List<PrzedmiotTemplate> l = new List<PrzedmiotTemplate>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                l = connection.Query<PrzedmiotTemplate>("dbo.spWyswietlWszystkiePrzedmiotyAlfabetycznie").ToList();
            }
            return l;
        }

        public List<PrzedmiotTemplate> PobierzPrzedmiotyZKlasy(int id_klasy)
        {
            List<PrzedmiotTemplate> l = new List<PrzedmiotTemplate>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                DynamicParameters d = new DynamicParameters();
                d.Add("@id_klasy", id_klasy);

                l = connection.Query<PrzedmiotTemplate>("dbo.spWszystkiePrzedmiotyZKlasy",d,commandType: CommandType.StoredProcedure).ToList();
            }
            return l;
        }

        public List<UczenTemplate> PobierzUczniowBezOcen()
        {
            List<UczenTemplate> l = new List<UczenTemplate>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                l = connection.Query<UczenTemplate>("dbo.spWyswietlWszystkichUczniowAlfabetycznie").ToList();
            }
            foreach (var uczen in l)
            {
                if (uczen.Pesel == "0")
                    uczen.Pesel = "nie podano peselu";
            }
            return l;
        }

        public List<UczenTemplate> PobierzUczniowZKlasy(int id_klasy)
        {
            List<UczenTemplate> l = new List<UczenTemplate>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                DynamicParameters d = new DynamicParameters();
                d.Add("@id_klasy", id_klasy);

                l = connection.Query<UczenTemplate>("dbo.spWszyscyUczniowieZKlasy", d, commandType: CommandType.StoredProcedure).ToList();
            }
            return l;
        }

        public List<Klasa> PobierzWszystkieKlasy()
        {
            List<Klasa> l = new List<Klasa>();
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                l = connection.Query<Klasa>("dbo.spWszystkieKlasy", commandType: CommandType.StoredProcedure).ToList();
            }
            return l;
        }

        public Klasa StworzKlase(Klasa klasa)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@nazwa", klasa.NazwaKlasy);
                p.Add("@wychowawca", null);
                p.Add("@rok", klasa.Rok.ToString());
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajKlase", p, commandType: CommandType.StoredProcedure);

                klasa.id = p.Get<int>("@id");
            }
            return klasa;
        }

        public PrzedmiotTemplate StworzPrzedmiot(PrzedmiotTemplate Model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                var p = new DynamicParameters();
                p.Add("@nazwa", Model.Nazwa);
                p.Add("@nauczyciel", Model.Nauczyciel);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajPrzedmiot", p, commandType: CommandType.StoredProcedure);

                Model.Id = p.Get<int>("@id");

            }
            return Model;
        }

        public void StworzRelacjePrzedmiotKlasa(int id_klasy, int id_przedmiotu)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                var p = new DynamicParameters();
                p.Add("@id_klasy", id_klasy);
                p.Add("@id_przedmiotu", id_przedmiotu);

                connection.Execute("dbo.spDodajRelacjePrzedmiotKlasa", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void StworzRelacjeUczenKlasa(int id_klasy, int id_ucznia)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                var p = new DynamicParameters();
                p.Add("@id_klasy", id_klasy);
                p.Add("@id_ucznia", id_ucznia);

                connection.Execute("dbo.spDodajRelacjeUczenKlasa", p, commandType: CommandType.StoredProcedure);
            }
        }

        public UczenTemplate StworzUcznia(UczenTemplate Model)
        {
            
            using (SqlConnection connection = new SqlConnection(GlobalConnector.ConnectionDetails(NazwaBazy)))
            {
                var p = new DynamicParameters();
                p.Add("@imie", Model.Imie);
                p.Add("@nazwisko", Model.Nazwisko);
                if (Model.Pesel != "")
                {
                    p.Add("@pesel", int.Parse(Model.Pesel));
                }
                else
                {
                    p.Add("@pesel", null);
                }
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajUcznia", p, commandType: CommandType.StoredProcedure);

                Model.Id = p.Get<int>("@id");

            }
            return Model;
        }
    }
}
