using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNone_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNone.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos");
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbbListaNomes.Items.Add(txtNone.Text);
                    txtNone.Clear();
                    txtNone.Focus();
               
                
                }
            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }

        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }
    }
}
