namespace Att_Introdução
{
    partial class FrmLoja
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formPrefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPrefeitoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_país = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_fantasia = new System.Windows.Forms.Label();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPrefeitoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formPrefeitoToolStripMenuItem
            // 
            this.formPrefeitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPrefeitoToolStripMenuItem1,
            this.formToolStripMenuItem,
            this.frmAlimentoToolStripMenuItem});
            this.formPrefeitoToolStripMenuItem.Name = "formPrefeitoToolStripMenuItem";
            this.formPrefeitoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formPrefeitoToolStripMenuItem.Text = "Exibir";
            // 
            // formPrefeitoToolStripMenuItem1
            // 
            this.formPrefeitoToolStripMenuItem1.Name = "formPrefeitoToolStripMenuItem1";
            this.formPrefeitoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.formPrefeitoToolStripMenuItem1.Text = "FrmPrefeito";
            this.formPrefeitoToolStripMenuItem1.Click += new System.EventHandler(this.formPrefeitoToolStripMenuItem1_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formToolStripMenuItem.Text = "FrmLoja";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // frmAlimentoToolStripMenuItem
            // 
            this.frmAlimentoToolStripMenuItem.Name = "frmAlimentoToolStripMenuItem";
            this.frmAlimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frmAlimentoToolStripMenuItem.Text = "FrmAlimento";
            this.frmAlimentoToolStripMenuItem.Click += new System.EventHandler(this.frmAlimentoToolStripMenuItem_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(290, 394);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 33);
            this.btn_limpar.TabIndex = 45;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(290, 318);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(129, 33);
            this.btn_registrar.TabIndex = 44;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(290, 261);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(129, 20);
            this.txt_cep.TabIndex = 43;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(290, 196);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(129, 20);
            this.txt_numero.TabIndex = 42;
            // 
            // txt_país
            // 
            this.txt_país.Location = new System.Drawing.Point(290, 127);
            this.txt_país.Name = "txt_país";
            this.txt_país.Size = new System.Drawing.Size(129, 20);
            this.txt_país.TabIndex = 41;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(35, 401);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(197, 20);
            this.txt_bairro.TabIndex = 40;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(35, 331);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(197, 20);
            this.txt_complemento.TabIndex = 39;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(35, 261);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(197, 20);
            this.txt_rua.TabIndex = 38;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(35, 196);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(197, 20);
            this.txt_cidade.TabIndex = 37;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(35, 127);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(197, 20);
            this.txt_cpf.TabIndex = 36;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(35, 65);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(197, 20);
            this.txt_nome.TabIndex = 34;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(285, 99);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(45, 25);
            this.lbl_pais.TabIndex = 33;
            this.lbl_pais.Text = "País";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(47, 168);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(71, 25);
            this.lbl_cidade.TabIndex = 32;
            this.lbl_cidade.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bairro";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complemento.Location = new System.Drawing.Point(47, 303);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(131, 25);
            this.lbl_complemento.TabIndex = 30;
            this.lbl_complemento.Text = "Complemento";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(285, 168);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(81, 25);
            this.lbl_numero.TabIndex = 29;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(47, 233);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(74, 25);
            this.lbl_rua.TabIndex = 28;
            this.lbl_rua.Text = "Rua/AV";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(285, 233);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(45, 25);
            this.lbl_cep.TabIndex = 27;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_fantasia
            // 
            this.lbl_fantasia.AutoSize = true;
            this.lbl_fantasia.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fantasia.Location = new System.Drawing.Point(47, 37);
            this.lbl_fantasia.Name = "lbl_fantasia";
            this.lbl_fantasia.Size = new System.Drawing.Size(80, 25);
            this.lbl_fantasia.TabIndex = 26;
            this.lbl_fantasia.Text = "Fantasia";
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.Location = new System.Drawing.Point(47, 99);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(55, 25);
            this.lbl_cnpj.TabIndex = 24;
            this.lbl_cnpj.Text = "CNPJ";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(286, 37);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(68, 25);
            this.lbl_estado.TabIndex = 46;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(290, 65);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(129, 20);
            this.txt_estado.TabIndex = 47;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_país);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_complemento);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_fantasia);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmLoja";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formPrefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPrefeitoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmAlimentoToolStripMenuItem;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_país;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_fantasia;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_estado;
    }
}