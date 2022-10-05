using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaNegocio
    {
        public IEnumerable<FACTURA> Consultas(string usuario)
        {
            try
            {
                var result = FacturaDato.Consultas(usuario);
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Solverix", $"Flujos - gesTbAccion ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }
    }
}
