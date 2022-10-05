using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Datos
{
    public class FacturaDato
    {
        public static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString; }
        }
        public static string connectionStringDinamica
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXIONDINAMICA"].ConnectionString; }
        }

        public static IEnumerable<FACTURA> Consultas(string usuario)
        {
            try
            {
                IDbConnection conexion = new SqlConnection(AccesoDB.DBDinamica(usuario));
                return conexion.Query<FACTURA>(FACTURA.SQL1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaArticulo ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }

        }
    }
}
