using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppArticulos.DAO
{
    public class ConexionBD
    {
        private const string CADENA = "SServer=DESKTOP-C0PCF1H;Database=ArticulosDBAccenture;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static SqlConnection connection = new SqlConnection(CADENA);
    }
}
