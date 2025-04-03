using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();

        }
        public void limparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResposta.Clear();
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtNumero1.Focus();
        }
        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //declarando as variáveis
                double num1, num2, resp = 0;

                // inicializar as variáveis 
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicar.Checked == false
                    && rdbDividir.Checked == false)
                {
                    MessageBox.Show("Selicione um operação", "mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                }
                else
                {

                

                //criando a estrutura de decisão
                if (rdbSomar.Checked)
                {
                    //somando valores 
                    resp = num1 + num2;
                }
                if (rdbMultiplicar.Checked)
                {
                    //multiplicando valores 
                    resp = num1 * num2;
                }
                if (rdbDividir.Checked)
                {
                    if (num2 == 0)
                    {


                        MessageBox.Show("Impossivel dividir por 0",
                            "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);

                        limparCampos();

                    }
                    else
                    {


                        //dividdindo valores 
                        resp = num1 / num2;
                    }
                        if (rdbSubtrair.Checked)
                        {
                            //Subtrair valores 
                            resp = num1 - num2;


                        }                    }
                    txtResposta.Text = resp.ToString();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores validos", "mensagem do sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error,
                         MessageBoxDefaultButton.Button1);




            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}