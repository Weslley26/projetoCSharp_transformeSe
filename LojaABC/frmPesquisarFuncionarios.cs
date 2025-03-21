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
    public partial class frmPesquisarFuncionarios : Form
    {//Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabelitarCampos();


        }
        public void desabelitarCampos()
        {


            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando o método limpar campos 
            LimpaCampos();
        }
        //criando o método limpar campos 
        public void LimpaCampos()
        {
            rdbCodigo.Checked = false ;
            rdbNome.Checked = false ;
            ltbPesquisar.Items.Clear();
            txtDescricao.Clear();
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Add(txtDescricao.Text);
            ltbPesquisar.Items.Clear();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
