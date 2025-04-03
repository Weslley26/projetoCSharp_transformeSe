namespace Componentes
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.txtNone = new System.Windows.Forms.TextBox();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.cbbListaNomes = new System.Windows.Forms.ComboBox();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.btnLimpar);
            this.gpbComponentes.Controls.Add(this.btnSair);
            this.gpbComponentes.Controls.Add(this.btnCarregar);
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.ckbComputador);
            this.gpbComponentes.Controls.Add(this.ckbMesa);
            this.gpbComponentes.Controls.Add(this.ckbBanana);
            this.gpbComponentes.Controls.Add(this.ckbLivros);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.txtNone);
            this.gpbComponentes.Controls.Add(this.lblListaNomes);
            this.gpbComponentes.Controls.Add(this.cbbListaNomes);
            this.gpbComponentes.Controls.Add(this.lblListaProdutos);
            this.gpbComponentes.Controls.Add(this.ltbListarProdutos);
            this.gpbComponentes.Controls.Add(this.lblNome);
            this.gpbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComponentes.Location = new System.Drawing.Point(25, 24);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(719, 491);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(321, 247);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(348, 161);
            this.pcbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagens.TabIndex = 12;
            this.pcbImagens.TabStop = false;
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(30, 341);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(116, 24);
            this.ckbComputador.TabIndex = 11;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(30, 371);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(67, 24);
            this.ckbMesa.TabIndex = 10;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(30, 401);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(84, 24);
            this.ckbBanana.TabIndex = 9;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(30, 311);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(69, 24);
            this.ckbLivros.TabIndex = 8;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(30, 254);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(66, 20);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Escolha";
            // 
            // txtNone
            // 
            this.txtNone.Location = new System.Drawing.Point(30, 81);
            this.txtNone.MaxLength = 30;
            this.txtNone.Name = "txtNone";
            this.txtNone.Size = new System.Drawing.Size(121, 26);
            this.txtNone.TabIndex = 6;
            this.txtNone.TextChanged += new System.EventHandler(this.txtNone_TextChanged);
            this.txtNone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNone_KeyDown);
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(30, 140);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(92, 20);
            this.lblListaNomes.TabIndex = 5;
            this.lblListaNomes.Text = "Listar nome";
            // 
            // cbbListaNomes
            // 
            this.cbbListaNomes.FormattingEnabled = true;
            this.cbbListaNomes.Location = new System.Drawing.Point(30, 163);
            this.cbbListaNomes.Name = "cbbListaNomes";
            this.cbbListaNomes.Size = new System.Drawing.Size(121, 28);
            this.cbbListaNomes.TabIndex = 4;
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Location = new System.Drawing.Point(321, 35);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(116, 20);
            this.lblListaProdutos.TabIndex = 3;
            this.lblListaProdutos.Text = "Listar Produtos";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.ItemHeight = 20;
            this.ltbListarProdutos.Location = new System.Drawing.Point(321, 58);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(348, 164);
            this.ltbListarProdutos.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(321, 425);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(126, 41);
            this.btnCarregar.TabIndex = 13;
            this.btnCarregar.Text = "Carregar Imagem ";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(453, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 41);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(565, 425);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 42);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbComponentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmComponentes";
            this.Text = "frmComponentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.TextBox txtNone;
        private System.Windows.Forms.Label lblListaNomes;
        private System.Windows.Forms.ComboBox cbbListaNomes;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.ListBox ltbListarProdutos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.PictureBox pcbImagens;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}