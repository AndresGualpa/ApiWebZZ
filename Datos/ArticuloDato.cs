using Dapper;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class ArticuloDato
   {
        public static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString; }
        }
        public static string connectionStringDinamica
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXIONDINAMICA"].ConnectionString; }
        }   

        public static IEnumerable<ARTICULO> Consultas(string usuario)
        {
            try
            {
                IDbConnection conexion = new SqlConnection(AccesoDB.DBDinamica(usuario));
                string usuariotemp = usuario;
                return conexion.Query<ARTICULO>(ARTICULO.SQL1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaArticulo ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
            
        }

        public int Insertar(ARTICULO articulo, string usuario)
        {
            try
            {
                IDbConnection conexion = new SqlConnection(AccesoDB.DBDinamica(usuario));
                conexion.Execute(ARTICULO.SQL2, param: articulo);
                return 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaArticulo ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }     
        }

        public int Actualizar(ARTICULO articulo, string usuario)
        {
            try
            {
                IDbConnection conexion = new SqlConnection(AccesoDB.DBDinamica(usuario));
                conexion.Execute(ARTICULO.SQL3, param: new { art_nom = articulo.art_nom,
                                                             art_est = articulo.art_est,
                                                             car_cod = articulo.car_cod,
                                                             art_prec= articulo.art_prec, art_cod = articulo.art_cod });
                return 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaArticulo ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }

        public int Eliminar(ARTICULO articulo, string usuario)
        {
            try
            {
                IDbConnection conexion = new SqlConnection(AccesoDB.DBDinamica(usuario));
                conexion.Execute(ARTICULO.SQL4, param: new { art_cod = articulo.art_cod });
                return 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - ConsultaArticulo ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }
    }
}
