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
    public class ClienteController : ApiController
    {
        [HttpGet]

        public OperationResult<IEnumerable<CLIENTE>> Consultas(string usuario)
        {

            try
            {
                var result = new ClienteNegocio().Consultas(usuario);
                if (result.Count() > 0)
                    return OperationResult<IEnumerable<CLIENTE>>.CreateSuccessResult(result);
                else
                    return OperationResult<IEnumerable<CLIENTE>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<IEnumerable<CLIENTE>>.CreateFailure(ex);
            }
        }
    }
}
