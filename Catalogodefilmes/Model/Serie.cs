using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogodefilmes.Model
{
    internal class Serie
    {
        private static int id;
        private static string nomeSerie;
        private static string temporadasSerie;
        private static string generoSerie;
        private static string estreiaSerie;
        private static string retornoSerie;

        public static int Id { get => id; set => id = value; }
        public static string NomeSerie { get => nomeSerie; set => nomeSerie = value; }
        public static string TemporadasSerie { get => temporadasSerie; set => temporadasSerie = value; }
        public static string GeneroSerie { get => generoSerie; set => generoSerie = value; }
        public static string EstreiaSerie { get => estreiaSerie; set => estreiaSerie = value; }
        public static string RetornoSerie { get => retornoSerie; set => retornoSerie = value; }
    }
}
