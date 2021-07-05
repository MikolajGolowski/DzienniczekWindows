using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DzienniczekLibrary;
using System.Data.SqlClient;
using System.Linq;

namespace DzienniczekUI
{
    public partial class KreatorKlas : Form
    {

        private List<UczenTemplate> DodaniUczniowie = new List<UczenTemplate>();
        private List<UczenTemplate> UczniowieDoWyboru = new List<UczenTemplate>();
        private List<UczenTemplate> UczniowieZBazy = new List<UczenTemplate>();

        private List<PrzedmiotTemplate> DodanePrzedmioty = new List<PrzedmiotTemplate>();
        private List<PrzedmiotTemplate> PrzedmiotyDoWyboru = new List<PrzedmiotTemplate>();
        private List<PrzedmiotTemplate> PrzedmiotyZBazy = new List<PrzedmiotTemplate>();

        public KreatorKlas()
        {
            InitializeComponent();
            
            UpdateComboUczen();
            UpdateComboPrzedmioty();
            SetComboRok();

        }

        private void SprawdzCzyDodanoUcznia()               //TODO ZMNIEJSZYC ZLOŻONOSC, MOZNA HASHOWAC PO ID
        {
            foreach (var uczen in UczniowieZBazy)
            {
                bool dodac = true;
                foreach (var dodany in DodaniUczniowie)
                {
                    if(uczen.Id == dodany.Id)
                    {
                        dodac = false;
                        break;
                    }
                }
                if (dodac)
                {
                    UczniowieDoWyboru.Add(uczen);
                }
            }
            
        }

        private void SprawdzCzyDodanoPrzedmiot()               //TODO ZMNIEJSZYC ZLOŻONOSC, MOZNA HASHOWAC PO ID
        {
            foreach (var przedmiot in PrzedmiotyZBazy)
            {
                bool dodac = true;
                foreach (var dodany in DodanePrzedmioty)
                {
                    if (przedmiot.Id == dodany.Id)
                    {
                        dodac = false;
                        break;
                    }
                }
                if (dodac)
                {
                    PrzedmiotyDoWyboru.Add(przedmiot);
                }
            }

        }
        private void KreatorKlas_Load(object sender, EventArgs e)
        {

        }

        private void SetComboRok() 
        {

            var l = new List<int>();
            for (int i = 1; i <= 8; i++)
            {
                l.Add(i);
            }
            RokComboBox.DataSource = l;

        }


        private void UpdateComboPrzedmioty()
        {
            PrzedmiotyDoWyboru.Clear();

            foreach (IDataConnection d in GlobalConnector.Connections)
            {
                PrzedmiotyZBazy = d.PobierzPrzedmioty();
            }

            SprawdzCzyDodanoPrzedmiot();

            PrzedmiotComboBox.DataSource = null;
            PrzedmiotComboBox.Items.Clear();
            PrzedmiotComboBox.DataSource = PrzedmiotyDoWyboru;
            PrzedmiotComboBox.DisplayMember = "NauczycielPrzedmiot";
        }

        private void UpdateComboUczen()
        {
            UczniowieDoWyboru.Clear();

            foreach (IDataConnection d in GlobalConnector.Connections)
            {
                UczniowieZBazy = d.PobierzUczniowBezOcen();
            }
            
            SprawdzCzyDodanoUcznia();

            UczenComboBox.DataSource = null;
            UczenComboBox.Items.Clear();
            UczenComboBox.DataSource = UczniowieDoWyboru;
            UczenComboBox.DisplayMember = "NazwiskoImie";
        }


        //dodawanie nowego przedmiotu
        private void PrzedmiotNowyButton_Click(object sender, EventArgs e)
        {
            // sprawdzenie poprawnosci danych
            bool Dobre = true;
            if(PrzedmiotNazwaTextBox.Text.Length == 0 || PrzedmiotNazwaTextBox.Text.Length > 50)
            {
                Dobre = false;
                PrzedmiotNazwaTextBox.BackColor = Color.FromArgb(255, 100, 100);
            }
            else 
            { 
                PrzedmiotNazwaTextBox.BackColor = Color.White; 
            }
            
            if(PrzedmiotNauczycielTextBox.Text.Length == 0 || PrzedmiotNauczycielTextBox.Text.Length>50)
            {
                Dobre = false;
                PrzedmiotNauczycielTextBox.BackColor = Color.FromArgb(255, 100, 100);
            }
            else
            {
                PrzedmiotNauczycielTextBox.BackColor = Color.White;
            }


            //wyslanie danych do zapisu
            if (Dobre)
            {
                List<PrzedmiotTemplate> p = new List<PrzedmiotTemplate>();
                foreach (IDataConnection d in GlobalConnector.Connections)
                {
                    PrzedmiotTemplate przedmiot = new PrzedmiotTemplate(PrzedmiotNazwaTextBox.Text, PrzedmiotNauczycielTextBox.Text);
                    d.StworzPrzedmiot(przedmiot);
                }

                PrzedmiotNazwaTextBox.BackColor = Color.White;
                PrzedmiotNauczycielTextBox.BackColor = Color.White;
                PrzedmiotNauczycielTextBox.Text = "";
                PrzedmiotNazwaTextBox.Text = "";

                UpdateComboPrzedmioty();

            }
        }


        //tworzenie nowego ucznia
        private void UczenNowyButton_Click(object sender, EventArgs e)
        {
            bool Dobre = true;
            if (UczenImieTextBox.Text.Length == 0 || UczenImieTextBox.Text.Length > 50)
            {
                Dobre = false;
                UczenImieTextBox.BackColor = Color.FromArgb(255, 100, 100);
            }
            else
            {
                UczenImieTextBox.BackColor = Color.White;
            }

            if (UczenNazwiskoTextBox.Text.Length == 0 || UczenNazwiskoTextBox.Text.Length > 50)
            {
                Dobre = false;
                UczenNazwiskoTextBox.BackColor = Color.FromArgb(255, 100, 100);
            }
            else
            {
                UczenNazwiskoTextBox.BackColor = Color.White;
            }

            string pesel="";
            if(UczenPeselTextBox.Text != "")
            {
                int p;
                pesel = UczenPeselTextBox.Text;
                if(!int.TryParse(pesel,out p) || pesel.Length != 9)
                {
                    Dobre = false;
                    UczenPeselTextBox.BackColor = Color.FromArgb(255, 100, 100);
                }
            }
            else
            {
                UczenPeselTextBox.BackColor = Color.White;
            }

            if (Dobre)
            {
                foreach (IDataConnection d in GlobalConnector.Connections)
                {
                    d.StworzUcznia(new UczenTemplate(
                        UczenImieTextBox.Text,
                        UczenNazwiskoTextBox.Text,
                        pesel));
                }

                UczenImieTextBox.BackColor = Color.White;
                UczenNazwiskoTextBox.BackColor = Color.White;
                UczenPeselTextBox.BackColor = Color.White;
                UczenImieTextBox.Text = "";
                UczenNazwiskoTextBox.Text = "";
                UczenPeselTextBox.Text = "";

                UpdateComboUczen();
            }
        }

        private void UczenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void UczenDoKlasyButton_Click(object sender, EventArgs e)
        {
            try
            {
                UczniowieListView.BeginUpdate();
                UczenTemplate u = (UczenTemplate)UczenComboBox.SelectedItem;
                DodaniUczniowie.Add(u);
                var wyswietl = new string[] { u.NazwiskoImie, u.Pesel };
                var Item = new ListViewItem(wyswietl);
                Item.Tag = u;
                UczniowieListView.Items.Add(Item);
                UpdateComboUczen();
                UczniowieListView.EndUpdate();
            }
            catch(Exception Ex)
            {
                MessageBox.Show($"Błąd! \n{Ex.Message}");
            }
        }

        private void PrzedmiotDoKlasyButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrzedmiotyListView.BeginUpdate();
                PrzedmiotTemplate u = (PrzedmiotTemplate)PrzedmiotComboBox.SelectedItem;
                DodanePrzedmioty.Add(u);
                var wyswietl = new string[] { u.Nazwa, u.Nauczyciel };
                var Item = new ListViewItem(wyswietl);
                Item.Tag = u;
                PrzedmiotyListView.Items.Add(Item);
                UpdateComboPrzedmioty();
                PrzedmiotyListView.EndUpdate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Błąd! \n{Ex.Message}");
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //sprawdzenie poprawnosci danych
            bool dobre = true;
            int buf; 
            if (RokComboBox.Text.Length == 0 )
            {
                dobre = false;
                RokComboBox.BackColor = Color.Red;
            }
            else
            {
                int a = 0;
                for (int i = 1; i <= 8; i++)
                {
                    if (i.ToString() == RokComboBox.Text)
                    {
                        a++;
                    }
                }
                if (a == 8 || !int.TryParse(RokComboBox.Text, out buf))
                {
                    dobre = false;
                    RokComboBox.BackColor = Color.Red;
                }
                else
                {
                    RokComboBox.BackColor = Color.White;
                }
            }

            if(NazwaKlasyTextBox.Text.Length == 0 || NazwaKlasyTextBox.Text.Length > 50)
            {
                NazwaKlasyTextBox.BackColor = Color.Red;
                dobre = false;
            }
            else
            {
                NazwaKlasyTextBox.BackColor = Color.White;
            }

            if (DodanePrzedmioty.Count() == 0 || DodaniUczniowie.Count() == 0)
            {
                MessageBox.Show("Klasa musi mieć przynajmniej jeden przedmiot i jednego ucznia");
                dobre = false;
            }

            if (dobre)
            {
                //stworzenie klasy
                Klasa klasa = new Klasa();
                klasa.NazwaKlasy = NazwaKlasyTextBox.Text;
                klasa.Rok = int.Parse(RokComboBox.Text);
                foreach (var przedmiot in DodanePrzedmioty)
                {
                    klasa.Przedmioty.Add(przedmiot);
                }
                foreach (var uczen in DodaniUczniowie)
                {
                    klasa.Uczniowie.Add(uczen);
                }
                foreach (var conn in GlobalConnector.Connections)
                {
                    klasa = conn.StworzKlase(klasa);                //TODO StworzKlase moze zwracac tylko id klasy
                }

                //dodanie relacji uczen-klasa
                foreach (var conn in GlobalConnector.Connections)
                {
                    foreach (var u in DodaniUczniowie)
                    {
                        conn.StworzRelacjeUczenKlasa(klasa.id, u.Id);
                    }
                }
                //dodanie relacji przedmiot-klasa
                foreach (var conn in GlobalConnector.Connections)
                {
                    foreach (var p in DodanePrzedmioty)
                    {
                        conn.StworzRelacjePrzedmiotKlasa(klasa.id, p.Id);
                    }
                }

                MessageBox.Show($"Dodano klasę {klasa.Rok} {klasa.NazwaKlasy}");


            }
        }
    }
}
