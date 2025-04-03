namespace FolhaDePagamento
{
    partial class form1FolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1FolhaDePagamento));
            this.lblFolhaDePagamento = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ccbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbbClubedeLazer = new System.Windows.Forms.ComboBox();
            this.lblClubeDeLazer = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblSalarioliquido = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtImpostoDeRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFolhaDePagamento
            // 
            this.lblFolhaDePagamento.AutoSize = true;
            this.lblFolhaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolhaDePagamento.Location = new System.Drawing.Point(45, 28);
            this.lblFolhaDePagamento.Name = "lblFolhaDePagamento";
            this.lblFolhaDePagamento.Size = new System.Drawing.Size(110, 20);
            this.lblFolhaDePagamento.TabIndex = 0;
            this.lblFolhaDePagamento.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(49, 118);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(627, 312);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 50);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcula";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ccbPlanoSaude
            // 
            this.ccbPlanoSaude.AutoSize = true;
            this.ccbPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbPlanoSaude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ccbPlanoSaude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ccbPlanoSaude.Location = new System.Drawing.Point(53, 216);
            this.ccbPlanoSaude.Name = "ccbPlanoSaude";
            this.ccbPlanoSaude.Size = new System.Drawing.Size(119, 24);
            this.ccbPlanoSaude.TabIndex = 4;
            this.ccbPlanoSaude.Text = "Plano Saúde";
            this.ccbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbbClubedeLazer
            // 
            this.cbbClubedeLazer.FormattingEnabled = true;
            this.cbbClubedeLazer.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClubedeLazer.Location = new System.Drawing.Point(48, 341);
            this.cbbClubedeLazer.Name = "cbbClubedeLazer";
            this.cbbClubedeLazer.Size = new System.Drawing.Size(121, 21);
            this.cbbClubedeLazer.TabIndex = 5;
            // 
            // lblClubeDeLazer
            // 
            this.lblClubeDeLazer.AutoSize = true;
            this.lblClubeDeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeDeLazer.Location = new System.Drawing.Point(53, 298);
            this.lblClubeDeLazer.Name = "lblClubeDeLazer";
            this.lblClubeDeLazer.Size = new System.Drawing.Size(116, 20);
            this.lblClubeDeLazer.TabIndex = 6;
            this.lblClubeDeLazer.Text = "Clube de Lazer";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(391, 118);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(106, 20);
            this.lblSalarioFolha.TabIndex = 7;
            this.lblSalarioFolha.Text = "Sálario Folha ";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(360, 185);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(138, 20);
            this.lblImpostoDeRenda.TabIndex = 8;
            this.lblImpostoDeRenda.Text = "Imposto de renda ";
            // 
            // lblSalarioliquido
            // 
            this.lblSalarioliquido.AutoSize = true;
            this.lblSalarioliquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioliquido.Location = new System.Drawing.Point(391, 258);
            this.lblSalarioliquido.Name = "lblSalarioliquido";
            this.lblSalarioliquido.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioliquido.TabIndex = 9;
            this.lblSalarioliquido.Text = "Sálario liquído";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Location = new System.Drawing.Point(539, 120);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFolha.TabIndex = 10;
            // 
            // txtImpostoDeRenda
            // 
            this.txtImpostoDeRenda.Location = new System.Drawing.Point(539, 185);
            this.txtImpostoDeRenda.Name = "txtImpostoDeRenda";
            this.txtImpostoDeRenda.Size = new System.Drawing.Size(100, 20);
            this.txtImpostoDeRenda.TabIndex = 11;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(539, 258);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 12;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(49, 155);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(627, 404);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 43);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(627, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 41);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // form1FolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoDeRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioliquido);
            this.Controls.Add(this.lblImpostoDeRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblClubeDeLazer);
            this.Controls.Add(this.cbbClubedeLazer);
            this.Controls.Add(this.ccbPlanoSaude);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFolhaDePagamento);
            this.Name = "form1FolhaDePagamento";
            this.Text = "Folha De Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolhaDePagamento;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox ccbPlanoSaude;
        private System.Windows.Forms.ComboBox cbbClubedeLazer;
        private System.Windows.Forms.Label lblClubeDeLazer;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblSalarioliquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtImpostoDeRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

