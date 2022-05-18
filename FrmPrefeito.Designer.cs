namespace Att_Introdução
{
    partial class FrmPrefeito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_país = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formPrefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPrefeitoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(24, 93);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(44, 25);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.Location = new System.Drawing.Point(262, 31);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(112, 25);
            this.lbl_nascimento.TabIndex = 1;
            this.lbl_nascimento.Text = "Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(262, 227);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(45, 25);
            this.lbl_cep.TabIndex = 3;
            this.lbl_cep.Text = "CEP";
            this.lbl_cep.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(24, 227);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(74, 25);
            this.lbl_rua.TabIndex = 4;
            this.lbl_rua.Text = "Rua/AV";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(262, 162);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(81, 25);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_complemento.Location = new System.Drawing.Point(24, 297);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(131, 25);
            this.lbl_complemento.TabIndex = 6;
            this.lbl_complemento.Text = "Complemento";
            this.lbl_complemento.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bairro";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(24, 162);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(71, 25);
            this.lbl_cidade.TabIndex = 8;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(262, 93);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(45, 25);
            this.lbl_pais.TabIndex = 9;
            this.lbl_pais.Text = "País";
            this.lbl_pais.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 59);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(197, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(267, 59);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(129, 20);
            this.txt_nascimento.TabIndex = 11;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(12, 121);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(197, 20);
            this.txt_cpf.TabIndex = 12;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(12, 190);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(197, 20);
            this.txt_cidade.TabIndex = 13;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(12, 255);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(197, 20);
            this.txt_rua.TabIndex = 14;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(12, 325);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(197, 20);
            this.txt_complemento.TabIndex = 15;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(12, 395);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(197, 20);
            this.txt_bairro.TabIndex = 16;
            // 
            // txt_país
            // 
            this.txt_país.Location = new System.Drawing.Point(267, 121);
            this.txt_país.Name = "txt_país";
            this.txt_país.Size = new System.Drawing.Size(129, 20);
            this.txt_país.TabIndex = 17;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(267, 190);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(129, 20);
            this.txt_numero.TabIndex = 18;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(267, 255);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(129, 20);
            this.txt_cep.TabIndex = 19;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(267, 312);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(129, 33);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(267, 388);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 33);
            this.btn_limpar.TabIndex = 21;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPrefeitoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 22;
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
            this.formPrefeitoToolStripMenuItem.Click += new System.EventHandler(this.formPrefeitoToolStripMenuItem_Click);
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
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 476);
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
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_complemento);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrefeito";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_país;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formPrefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPrefeitoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmAlimentoToolStripMenuItem;
    }
}

