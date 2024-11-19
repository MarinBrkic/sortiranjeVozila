using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortiranjeVozila
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMarka.Text == "" ||
    textBoxModel.Text == "" ||
    textBoxGodProizvodnje.Text == "" ||
    textBoxKilometraza.Text == "")
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                        "Pogrešan unos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    textBoxModel.Clear();
                    textBoxMarka.Clear();
                    textBoxGodProizvodnje.Clear();
                    textBoxKilometraza.Clear();
                    textBoxModel.Focus();
                }
                else
                {
                    Vozilo vozilo = new Vozilo(textBoxMarka.Text, textBoxModel.Text,
                        Convert.ToInt16(textBoxGodProizvodnje.Text), 
                        Convert.ToInt16(textBoxKilometraza.Text));

                    voziloList.Add(vozilo);
                    textBoxModel.Clear();
                    textBoxMarka.Clear();
                    textBoxGodProizvodnje.Clear();
                    textBoxKilometraza.Clear();
                    textBoxModel.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
    "Pogrešan unos", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                textBoxMarka.Clear();
                textBoxModel.Clear();
                textBoxGodProizvodnje.Clear();
                textBoxKilometraza.Clear();
            }

        }

        private void buttonSortiraj_Click(object sender, EventArgs e)
        {
            foreach ( Vozilo v in voziloList )
            {
                textBoxIspis.AppendText( v.ToString() );
            }
        }
    }
}
