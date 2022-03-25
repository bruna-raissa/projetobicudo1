using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBicudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnA.Text;
            if (btnA.BackColor == Color.Red)
            {
                btnA.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnA.Text, "");
            }
            else
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
        }

        private void btnListrado_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnListrado.Text;
            if (btnListrado.BackColor == Color.Red)
            {
                btnListrado.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnListrado.Text, "");
            }
            else
            btnListrado.BackColor = Color.Red;
            btnListrado.Enabled = false;
        }

        private void btnTem_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnTem.Text;
            if (btnTem.BackColor == Color.Red)
            {
                btnTem.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnTem.Text, "");
            }
            else
                btnTem.BackColor = Color.Red;
            btnTem.Enabled = false;
        }

        private void btnCorpo_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnCorpo.Text;
            if (btnCorpo.BackColor == Color.Red)
            {
                btnCorpo.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnCorpo.Text, "");
            }
            else
               btnCorpo.BackColor = Color.Red;
            btnA.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnO.Text;
            if (btnO.BackColor == Color.Red)
            {
                btnO.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnO.Text, "");
            }
            else
                btnO.BackColor = Color.Red;
                btnO.Enabled = false;
        }

        private void btnZebra_Click(object sender, EventArgs e)
        {
            txtzembra.Text += " " + btnZebra.Text;
            if (btnZebra.BackColor == Color.Red)
            {
                btnZebra.BackColor = Color.Thistle;
                txtzembra.Text = txtzembra.Text.Replace(btnZebra.Text, "");
            }
            else
                btnZebra.BackColor = Color.Red;
            btnZebra.Enabled = false;
        }

        private void btnPeixe_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnPeixe.Text;
            if (btnPeixe.BackColor == Color.Red)
            {
                btnPeixe.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnPeixe.Text, "");
            }
            else
                btnPeixe.BackColor = Color.Red;
                btnPeixe.Enabled = false;
        }

        private void btnLagoa_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnLagoa.Text;
            if (btnLagoa.BackColor == Color.Red)
            {
                btnLagoa.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnLagoa.Text, "");
            }
            else
                btnLagoa.BackColor = Color.Red;
            btnLagoa.Enabled = false;
        }
    }
}
