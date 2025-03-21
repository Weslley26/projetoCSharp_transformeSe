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
            this.lblNome = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.cbbListaNomes = new System.Windows.Forms.ComboBox();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.txtNone = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.ItemHeight = 20;
            this.ltbListarProdutos.Location = new System.Drawing.Point(321, 110);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(348, 164);
            this.ltbListarProdutos.TabIndex = 1;
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Location = new System.Drawing.Point(317, 87);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(116, 20);
            this.lblListaProdutos.TabIndex = 3;
            this.lblListaProdutos.Text = "Listar Produtos";
            // 
            // cbbListaNomes
            // 
            this.cbbListaNomes.FormattingEnabled = true;
            this.cbbListaNomes.Location = new System.Drawing.Point(129, 149);
            this.cbbListaNomes.Name = "cbbListaNomes";
            this.cbbListaNomes.Size = new System.Drawing.Size(121, 28);
            this.cbbListaNomes.TabIndex = 4;
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(22, 157);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(92, 20);
            this.lblListaNomes.TabIndex = 5;
            this.lblListaNomes.Text = "Listar nome";
            // 
            // txtNone
            // 
            this.txtNone.Location = new System.Drawing.Point(94, 84);
            this.txtNone.MaxLength = 30;
            this.txtNone.Name = "txtNone";
            this.txtNone.Size = new System.Drawing.Size(100, 26);
            this.txtNone.TabIndex = 6;
            this.txtNone.TextChanged += new System.EventHandler(this.txtNone_TextChanged);
            this.txtNone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNone_KeyDown);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(26, 254);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(66, 20);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Escolha";
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
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
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
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
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
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
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
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(321, 295);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(348, 180);
            this.pcbImagens.TabIndex = 12;
            this.pcbImagens.TabStop = false;
            this.pcbImagens.Click += new System.EventHandler(this.pictureBox1_Click);
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
    }
}