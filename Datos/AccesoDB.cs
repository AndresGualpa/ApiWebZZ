using Dapper;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class AccesoDB
    {

        public static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString; }
        }

        public static string connectionStringDinamica
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXIONDINAMICA"].ConnectionString; }
        }

        public static List<acceso> ConsultaAcceso(string usuario)
        {
            try
            {
                using (IDbConnection conexion = new SqlConnection(connectionString))
                {
                    string usuariotemp = usuario;
                    var result = conexion.Query<acceso>(acceso.SQL1, param: new { usuario }).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaAcceso ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }

        public static string DBDinamica(string usuario)
            {
            var conexionDinamica = ConsultaAcceso(usuario);
            string usuariotemp = usuario;
            string ScrtCon = ConfigurationManager.ConnectionStrings["CONEXIONDINAMICA"].ToString();
            ScrtCon = string.Format(ScrtCon, conexionDinamica[0].emp_db);

            return ScrtCon;
            }
    }
}
