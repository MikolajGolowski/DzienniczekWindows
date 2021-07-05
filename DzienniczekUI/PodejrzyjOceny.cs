using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DzienniczekLibrary;

namespace DzienniczekUI
{
    public partial class PodejrzyjOceny : Form
    {
        private List<Klasa> KlasyDostepne = new List<Klasa>();

        public PodejrzyjOceny()
        {
            InitializeComponent();

            InitializeWyborKlasy();
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

        private void KlasaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                UpdateWyborUcznia();
                UpdateWyborPrzedmiotu();
            }
            catch (Exception Ex)
            {
                PrzedmiotComboBox.Text = "Wybierz ucznia";
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                OcenyLista.BeginUpdate();
                OcenyLista.Items.Clear();
                List<OcenaTemplate> u = new List<OcenaTemplate>();
                foreach (var conn in GlobalConnector.Connections)
                {
                    u = conn.PobierzOcenyUcznia(((UczenTemplate)UczenComboBox.SelectedItem).Id, ((PrzedmiotTemplate)PrzedmiotComboBox.SelectedItem).Id);
                }
                foreach (var ocena in u)
                {
                    var wyswietl = new string[] { ocena.Ocena, ocena.Opis };
                    var Item = new ListViewItem(wyswietl);
                    Item.Tag = ocena;
                    OcenyLista.Items.Add(Item);
                }
                OcenyLista.EndUpdate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Błąd! \n{Ex.Message}");
            }
        }
    }
}
