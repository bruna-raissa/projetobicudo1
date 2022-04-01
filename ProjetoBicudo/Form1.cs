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

        private void btnDourado_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnDourado.Text;
            if (btnDourado.BackColor == Color.Red)
            {
                btnDourado.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnDourado.Text, "");
            }
            else
                btnDourado.BackColor = Color.Red;
            btnDourado.Enabled = false;

        }

        private void btnNada_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnNada.Text;
            if (btnNada.BackColor == Color.Red)
            {
                btnNada.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnNada.Text, "");
            }
            else
                btnNada.BackColor = Color.Red;
            btnNada.Enabled = false;
        }

        private void btnOPeixe_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnOPeixe.Text;
            if (btnOPeixe.BackColor == Color.Red)
            {
                btnOPeixe.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnOPeixe.Text, "");
            }
            else
                btnOPeixe.BackColor = Color.Red;
            btnOPeixe.Enabled = false;
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            txtpeixe.Text += " " + btnNa.Text;
            if (btnNa.BackColor == Color.Red)
            {
                btnNa.BackColor = Color.Thistle;
                txtpeixe.Text = txtpeixe.Text.Replace(btnNa.Text, "");
            }
            else
                btnNa.BackColor = Color.Red;
            btnNa.Enabled = false;
        }

        private void btnJoaninha_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnJoaninha.Text;
            if (btnJoaninha.BackColor == Color.Red)
            {
                btnJoaninha.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnJoaninha.Text, "");
            }
            else
                btnJoaninha.BackColor = Color.Red;
            btnJoaninha.Enabled = false;
        }

        private void btnInseto_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnInseto.Text;
            if (btnInseto.BackColor == Color.Red)
            {
                btnInseto.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnInseto.Text, "");
            }
            else
                btnInseto.BackColor = Color.Red;
            btnInseto.Enabled = false;
        }

        private void btnPequeno_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnPequeno.Text;
            if (btnPequeno.BackColor == Color.Red)
            {
                btnPequeno.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnPequeno.Text, "");
            }
            else
                btnPequeno.BackColor = Color.Red;
            btnPequeno.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnE.Text;
            if (btnE.BackColor == Color.Red)
            {
                btnE.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnE.Text, "");
            }
            else
                btnE.BackColor = Color.Red;
            btnE.Enabled = false;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnUm.Text;
            if (btnUm.BackColor == Color.Red)
            {
                btnUm.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnUm.Text, "");
            }
            else
                btnUm.BackColor = Color.Red;
            btnUm.Enabled = false;
        }

        private void btnAJoaninha_Click(object sender, EventArgs e)
        {
            txtjoaninha.Text += " " + btnAJoaninha.Text;
            if (btnAJoaninha.BackColor == Color.Red)
            {
                btnAJoaninha.BackColor = Color.Thistle;
                txtjoaninha.Text = txtpeixe.Text.Replace(btnAJoaninha.Text, "");
            }
            else
                btnAJoaninha.BackColor = Color.Red;
            btnAJoaninha.Enabled = false;
        }
    }
}
