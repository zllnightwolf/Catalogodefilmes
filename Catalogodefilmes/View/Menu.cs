using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogodefilmes.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme cadastroFilme = new TelaCadastroFilme();
            cadastroFilme.Show();
        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            TelaCadastroSerie cadastroSerie = new TelaCadastroSerie();
            cadastroSerie.Show();
        }
    }
}
