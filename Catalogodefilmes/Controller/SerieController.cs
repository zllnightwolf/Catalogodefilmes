using Catalogodefilmes.Model;
using Catalogodefilmes.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogodefilmes.Controller
{
    internal class SerieController
    {
        public void CadastrarSerie()
        {
            SqlConnection sn = new SqlConnection(Conexao.Conectar());
            SqlCommand smd = new SqlCommand("InserirSeriesP", sn);
            smd.CommandType = CommandType.StoredProcedure;

            try
            {
                smd.Parameters.AddWithValue("@nome", Serie.NomeSerie);
                smd.Parameters.AddWithValue("@temporadas", Serie.TemporadasSerie);
                smd.Parameters.AddWithValue("@genero", Serie.GeneroSerie);
                smd.Parameters.AddWithValue("@estreia", Serie.EstreiaSerie);

                SqlParameter sv = smd.Parameters.Add("@id", SqlDbType.Int);
                sv.Direction = ParameterDirection.Output;
                sn.Open();
                smd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Série cadastrada com Sucesso, deseja cadastrar outra?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(resposta == DialogResult.Yes)
                {
                    Serie.NomeSerie = string.Empty;
                    Serie.EstreiaSerie = string.Empty;
                    Serie.GeneroSerie = string.Empty;
                    Serie.TemporadasSerie = string.Empty;
                    Serie.RetornoSerie = string.Empty;
                }
                else
                {
                    Serie.RetornoSerie = "f";
                    return;
                }
            }catch(Exception)
            {

                throw;
            }
        }

    }
}
