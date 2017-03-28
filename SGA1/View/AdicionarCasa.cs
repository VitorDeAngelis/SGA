using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA1.Model;

namespace SGA1.View
{
    public partial class AdicionarCasa : UserControl
    {
        public AdicionarCasa()
        {
            InitializeComponent();
        }

        private void NumQuartosTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void NumBanheirosTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Casa a = new Casa();

            a.Nome = NomeTB.Text;
            a.Endereco = EnderecoTB.Text;
            a.CapacidadeMaxima = Int32.Parse(CapMaxTB.Text);
            a.ValorDiaria = Int32.Parse(ValorDiTB.Text);
            a.NumBanheiros = Int32.Parse(NumBanheirosTB.Text);
            a.NumQuartos = Int32.Parse(NumQuartosTB.Text);

            if (LareiraCB.Checked)
            {
                a.Lareira = true;
            }
        }

        private void CapMaxTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void ValorDiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
