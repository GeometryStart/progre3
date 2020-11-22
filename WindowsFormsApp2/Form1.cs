using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnTervita_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tere tulemast meie esimesse WinForms rakendusse", "Tervitus",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
