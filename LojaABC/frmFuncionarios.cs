using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFuncionarios()
        {

            InitializeComponent();
            //desabilitar campos 
            Desabilitarcampos();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }


        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void cbbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //executando habilitar campos
            habilitarcampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();

        }
        //deesabilitantando os componentes
        public void Desabilitarcampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataDeNascimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbSexo.Enabled = false;

            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            mskCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            cbbUF.Enabled = false;
            txtComplemento.Enabled = false;


            btnCadastra.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }
        public void habilitarcampos()
        {


            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            mskCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            cbbUF.Enabled = true;
            txtComplemento.Enabled = true;


            btnCadastra.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            dtpDataDeNascimento.Text = "";
            mskCelular.Clear();
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            rdbNaoDesejoInformar.Checked = false;

            txtLogradouro.Clear();
            txtNumero.Clear();
            mskCEP.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtComplemento.Clear();

            txtNome.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskCelular.Text.Equals("     -") ||
                txtLogradouro.Text.Equals("") ||
                txtComplemento.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                txtEstado.Text.Equals("") ||
                mskCEP.Text.Equals("     -") ||
                cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os Campos!!!");
            }
            else
            {
                MessageBox.Show("Cadastrar con Sucesso!!!");
            }
           }
        }
    }
