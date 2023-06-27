using Catalogodefilmes.Controller;
using Catalogodefilmes.Model;
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
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txtSerie.Text;
            Serie.EstreiaSerie = txtEstreia.Text;
            Serie.TemporadasSerie = txtTemporadas.Text;
            Serie.GeneroSerie = cbGenero.Text;

            SerieController serieController = new SerieController();
            serieController.CadastrarSerie();

            txtSerie.Text = Serie.NomeSerie;
            txtEstreia.Text = Serie.EstreiaSerie;
            txtTemporadas.Text= Serie.TemporadasSerie;
            cbGenero.Text = Serie.GeneroSerie;

            if(Serie.RetornoSerie == "f")
            {
                this.Close();
            }
        }
        public void FecharTela()
        {
            this.Close();
        }
    }
}
