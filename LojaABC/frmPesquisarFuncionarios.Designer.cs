﻿
namespace LojaABC
{
    partial class frmPesquisarFuncionarios
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
            System.Windows.Forms.Button btnLimpar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.gpbPesquisarPor = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.lbldescriçao = new System.Windows.Forms.Label();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            this.gpbPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            btnLimpar.Location = new System.Drawing.Point(666, 120);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(116, 102);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "&Limpar";
            btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbPesquisarPor
            // 
            this.gpbPesquisarPor.Controls.Add(this.txtDescricao);
            this.gpbPesquisarPor.Controls.Add(this.rdbNome);
            this.gpbPesquisarPor.Controls.Add(this.rdbCodigo);
            this.gpbPesquisarPor.Controls.Add(this.lbldescriçao);
            this.gpbPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarPor.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarPor.Name = "gpbPesquisarPor";
            this.gpbPesquisarPor.Size = new System.Drawing.Size(648, 104);
            this.gpbPesquisarPor.TabIndex = 0;
            this.gpbPesquisarPor.TabStop = false;
            this.gpbPesquisarPor.Text = "Pesquisar por";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 67);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(360, 26);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(250, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(126, 25);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // lbldescriçao
            // 
            this.lbldescriçao.AutoSize = true;
            this.lbldescriçao.Location = new System.Drawing.Point(30, 70);
            this.lbldescriçao.Name = "lbldescriçao";
            this.lbldescriçao.Size = new System.Drawing.Size(80, 20);
            this.lbldescriçao.TabIndex = 3;
            this.lbldescriçao.Text = "Descrição";
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.ItemHeight = 20;
            this.ltbPesquisar.Location = new System.Drawing.Point(12, 120);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(648, 104);
            this.ltbPesquisar.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(666, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(116, 97);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 228);
            this.Controls.Add(btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.gpbPesquisarPor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Pesquisar Funcionários";
            this.Load += new System.EventHandler(this.frmPesquisarFuncionarios_Load);
            this.gpbPesquisarPor.ResumeLayout(false);
            this.gpbPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarPor;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Label lbldescriçao;
        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}