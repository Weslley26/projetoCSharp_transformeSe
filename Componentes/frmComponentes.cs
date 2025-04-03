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

        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "salecione um imagem";
            ofd.Title = "documentos|*.jpg;*.jpeg;*.png;*.bmp|todos os arquivos|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbImagens.ImageLocation = ofd.FileName;
                pcbImagens.Load();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            pcbImagens.Image = null;
        }
    }
}
