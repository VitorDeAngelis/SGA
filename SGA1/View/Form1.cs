using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA1.View;

namespace SGA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AdicionarCasa a = new AdicionarCasa();
            panel1.Controls.Add(a);
        }
    }
}
