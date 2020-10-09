using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class FormTampilNama : Form
    {
        public FormTampilNama()
        {
            InitializeComponent();

            btnHapus.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnTampil_Click(object sender, EventArgs e)
        {
            string input = txtNama.Text;

            MessageBox.Show(input, "Hai!");

            btnHapus.Enabled = true;
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
        }
    }
}
