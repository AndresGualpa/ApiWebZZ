using ApiWeb.Seguridad;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class FacturaController : ApiController
    {
        [HttpGet]

        public OperationResult<IEnumerable<FACTURA>> Consultas(string usuario)
        {

            try
            {
                var result = new FacturaNegocio().Consultas(usuario);
                if (result.Count() > 0)
                    return OperationResult<IEnumerable<FACTURA>>.CreateSuccessResult(result);
                else
                    return OperationResult<IEnumerable<FACTURA>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<IEnumerable<FACTURA>>.CreateFailure(ex);
            }
        }
    }
}
