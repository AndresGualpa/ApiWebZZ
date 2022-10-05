using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public IEnumerable<ARTICULO> Consultas(string usuario)
        {
            try
            {
                var result = ArticuloDato.Consultas(usuario);
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Solverix", $"Flujos - gesTbAccion ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }

        public int Insertar(ARTICULO articulo,string usuario)
        {
            try
            {
                return new ArticuloDato().Insertar(articulo, usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Actualizar(ARTICULO articulo, string usuario)
        {
            try
            {
                return new ArticuloDato().Actualizar(articulo,usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Eliminar(ARTICULO articulo, string usuario)
        {
            try
            {
                return new ArticuloDato().Eliminar(articulo, usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
