using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienniczekUI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void KreatorKlasPrzycisk_Click(object sender, EventArgs e)
        {
            KreatorKlas f = new KreatorKlas();
            f.Show();
        }

        private void DodajOcenePrzycisk_Click(object sender, EventArgs e)
        {
            DodawanieOceny f = new DodawanieOceny();
            f.Show();
        }

        private void PodejrzyjOcenyPrzycisk_Click(object sender, EventArgs e)
        {
            PodejrzyjOceny f = new PodejrzyjOceny();
            f.Show();
        }

        private void WyjsciePrzycisk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
