using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            //todo formulario es una clase 
            // y lo debemos de llamar como una clase 

            FrmcaraFeliz objCf = new FrmcaraFeliz();

            objCf.ShowDialog();
        }

        private void aUnFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmcaraFeliz objCf = new FrmcaraFeliz();

            objCf.ShowDialog();
        }

        private void caraTristeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCaraTriste objCf = new FrCaraTriste();

            objCf.ShowDialog();
        }
    }
}
