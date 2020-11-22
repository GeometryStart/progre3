using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTervita_Click(object sender, EventArgs e)
        {
            string tekst = txtNimi.Text;
            if (string.IsNullOrEmpty(tekst))
            {
                MessageBox.Show("Palun sisesta oma nimi", "Oot-oot",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show($"Tere tulemast, {tekst} meie esimesse WinForms rakendusse", "Tervitus",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
