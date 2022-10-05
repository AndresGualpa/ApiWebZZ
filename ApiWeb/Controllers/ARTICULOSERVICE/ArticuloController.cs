using ApiWeb.Seguridad;
using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Negocio;
using System.Web.Http.Cors;

namespace ApiWeb.Controllers.ARTICULOSERVICE
{
    public class ArticuloController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELET,PATCH,OPTIONS")]
        [HttpGet]

        public OperationResult<IEnumerable<ARTICULO>> Consultas(string usuario)
        {

            try
            {
                var result = new ArticuloNegocio().Consultas(usuario);
                if (result.Count() > 0)
                    return OperationResult<IEnumerable<ARTICULO>>.CreateSuccessResult(result);
                else
                    return OperationResult<IEnumerable<ARTICULO>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<IEnumerable<ARTICULO>>.CreateFailure(ex);
            }
        }

        [HttpPost]
        public OperationResult<int> Insertar(ARTICULO articulo, string usuario)
        {
            try
            {
                var result = new ArticuloNegocio().Insertar(articulo, usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al crear el ARTICULO");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }

        [HttpPut]
        public OperationResult<int> Actualizar(ARTICULO articulo, string usuario)
        {
            try
            {
                var result = new ArticuloNegocio().Actualizar(articulo,usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al Actualizar su Articulo");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }


        [HttpDelete]
        public OperationResult<int> Eliminar(ARTICULO articulo, string usuario)
        {
            try
            {
                var result = new ArticuloNegocio().Eliminar(articulo, usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al Eliminar su Articulo");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }
    }
}
