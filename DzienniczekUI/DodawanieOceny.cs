using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DzienniczekLibrary;

namespace DzienniczekUI
{
    public partial class DodawanieOceny : Form
    {

        private List<Klasa> KlasyDostepne = new List<Klasa>();

        public DodawanieOceny()
        {
            InitializeComponent();

            InitializeWyborKlasy();
            InitializeOceny();
        }

        private void InitializeOceny()
        {
            int[] c = { 2, 3, 4, 5 };
            List<String> s = new List<string>();
            s.Add($"1");
            s.Add($"1+");
            foreach (var w in c)
            {
                s.Add($"{w}-");
                s.Add($"{w}");
                s.Add($"{w}+");
            }
            s.Add($"6-");
            s.Add($"6");
            OcenaComboBox.DataSource = s;

            List<string> z = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                z.Add(i.ToString());
            }
            WagaComboBox.DataSource = z; 
        }

        private void UpdateWyborUcznia()
        {
            List<UczenTemplate> u = new List<UczenTemplate>();
            foreach (var conn in GlobalConnector.Connections)
            {
                int id = ((Klasa)KlasaComboBox.SelectedItem).id;
                u = conn.PobierzUczniowZKlasy(id);
            }
            UczenComboBox.DataSource = null;
            UczenComboBox.Items.Clear();
            UczenComboBox.DataSource = u;
            UczenComboBox.DisplayMember = "NazwiskoImie";
        }

        private void UpdateWyborPrzedmiotu()
        {
            List<PrzedmiotTemplate> u = new List<PrzedmiotTemplate>();
            foreach (var conn in GlobalConnector.Connections)
            {
                int id = ((Klasa)KlasaComboBox.SelectedItem).id;
                u = conn.PobierzPrzedmiotyZKlasy(id);
            }
            PrzedmiotComboBox.DataSource = null;
            PrzedmiotComboBox.Items.Clear();
            PrzedmiotComboBox.DataSource = u;
            PrzedmiotComboBox.DisplayMember = "Nazwa";
        }

        private void InitializeWyborKlasy()
        {
            foreach (var conn in GlobalConnector.Connections)
            {
                KlasyDostepne = conn.PobierzWszystkieKlasy();
            }
            KlasaComboBox.DataSource = KlasyDostepne;
            KlasaComboBox.DisplayMember = "DisplayNazwa";
        }

        private void DodawanieOceny_Load(object sender, EventArgs e)
        {

        }

        private void OpisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KlasaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateWyborUcznia();
                UpdateWyborPrzedmiotu();
            }
            catch(Exception Ex)
            {
                PrzedmiotComboBox.Text = "Wybierz ucznia";
            }
        }

        private void UczenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajOceneButton_Click(object sender, EventArgs e)
        {
            bool dobre = true;
            OcenaTemplate ocena = new OcenaTemplate();
            int pom = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (OcenaComboBox.Text[0] - '0' == i)
                    pom++;
            }
            if (pom == 6 || OcenaComboBox.Text.Length > 2)
            {
                dobre = false;
                OcenaComboBox.BackColor = Color.Red;
            }
            else if (OcenaComboBox.Text.Length == 2)
            {
                if (OcenaComboBox.Text[1] != '+' && OcenaComboBox.Text[1] != '-')
                {
                    dobre = false;
                    OcenaComboBox.BackColor = Color.Red;
                }
            }
            else
            {
                OcenaComboBox.BackColor = Color.White;
            }
            if (dobre)
            {
                try
                {
                    ocena.Ocena = OcenaComboBox.Text;
                    ocena.Opis = OpisTextBox.Text;
                    ocena.Waga = short.Parse(WagaComboBox.Text);
                    ocena.Id_przedmiotu = ((PrzedmiotTemplate)PrzedmiotComboBox.SelectedItem).Id;
                    ocena.Id_ucznia = ((UczenTemplate)UczenComboBox.SelectedItem).Id;
                }
                catch (Exception ex)
                {
                    dobre = false;
                }
                if (dobre)
                {
                    foreach (var conn in GlobalConnector.Connections)
                    {
                        conn.DodajOcene(ocena);
                    }

                    MessageBox.Show($"Pomyślnie dodano ocenę {ocena.Ocena} uczniowi {((UczenTemplate)UczenComboBox.SelectedItem).NazwiskoImie}");
                }
            }
            
            
        }
    }
}
