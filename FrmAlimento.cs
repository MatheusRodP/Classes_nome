using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Att_Introdução
{
    public partial class FrmAlimento : Form
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }

        private void formPrefeitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void frmAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }
    }
}
