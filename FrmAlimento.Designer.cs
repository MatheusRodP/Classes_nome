namespace Att_Introdução
{
    partial class FrmAlimento
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
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_calorias = new System.Windows.Forms.Label();
            this.lbl_desconto10 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_ingrediente = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPrefeitoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
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
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(119, 294);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(197, 20);
            this.txt_complemento.TabIndex = 34;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(119, 229);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(197, 20);
            this.txt_rua.TabIndex = 33;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(119, 160);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(197, 20);
            this.txt_cidade.TabIndex = 32;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(119, 98);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(197, 20);
            this.txt_cpf.TabIndex = 31;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(119, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(197, 20);
            this.txt_nome.TabIndex = 30;
            // 
            // lbl_calorias
            // 
            this.lbl_calorias.AutoSize = true;
            this.lbl_calorias.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calorias.Location = new System.Drawing.Point(177, 132);
            this.lbl_calorias.Name = "lbl_calorias";
            this.lbl_calorias.Size = new System.Drawing.Size(80, 25);
            this.lbl_calorias.TabIndex = 29;
            this.lbl_calorias.Text = "Calorias";
            // 
            // lbl_desconto10
            // 
            this.lbl_desconto10.AutoSize = true;
            this.lbl_desconto10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desconto10.Location = new System.Drawing.Point(184, 266);
            this.lbl_desconto10.Name = "lbl_desconto10";
            this.lbl_desconto10.Size = new System.Drawing.Size(66, 25);
            this.lbl_desconto10.TabIndex = 27;
            this.lbl_desconto10.Text = "10% +";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(184, 201);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(56, 25);
            this.lbl_valor.TabIndex = 26;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(184, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(63, 25);
            this.lbl_nome.TabIndex = 25;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_ingrediente
            // 
            this.lbl_ingrediente.AutoSize = true;
            this.lbl_ingrediente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrediente.Location = new System.Drawing.Point(161, 70);
            this.lbl_ingrediente.Name = "lbl_ingrediente";
            this.lbl_ingrediente.Size = new System.Drawing.Size(109, 25);
            this.lbl_ingrediente.TabIndex = 24;
            this.lbl_ingrediente.Text = "Ingrediente";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(246, 363);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 33);
            this.btn_limpar.TabIndex = 36;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(82, 363);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(129, 33);
            this.btn_registrar.TabIndex = 35;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 440);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_calorias);
            this.Controls.Add(this.lbl_desconto10);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_ingrediente);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAlimento";
            this.Text = "Form3";
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
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_calorias;
        private System.Windows.Forms.Label lbl_desconto10;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_ingrediente;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_registrar;
    }
}