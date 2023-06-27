using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogodefilmes.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joao.vnrsantos\source\repos\Catalogodefilmes\Catalogodefilmes\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
