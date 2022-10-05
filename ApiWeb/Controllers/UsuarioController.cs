using Entidades;
using System.Web.Http;
using Entidades;
using Negocio;
using System.Collections.Generic;
using ApiWeb.Seguridad;
using System.Linq;
using System.Web.Http.Cors;

namespace ApiWeb.Controllers
{
    [EnableCors(origins: "*", headers:"*",methods:"GET,POST,PUT,DELET,PATCH,OPTIONS")]
    public class UsuarioController : ApiController
    {
        
        [HttpGet]
        public OperationResult<List<Usuario>> LoginUsuario(string usuario, string clave)
        {

            try
            {
                var result = new UsuarioNegocio().LoginUsuario(usuario,clave);
                if (result.Count() > 0)
                    return OperationResult<List<Usuario>>.CreateSuccessResult(result);
                else
                    return OperationResult<List<Usuario>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<List<Usuario>>.CreateFailure(ex);
            }
        }


        //-----------------------------------------
        [HttpGet]
        public OperationResult<List<Usuario>> ExistenciaUsuario(string usuario)
        {

            try
            {
                var result = new UsuarioNegocio().ExistenciaUsuario(usuario);
                if (result.Count() > 0)
                    return OperationResult<List<Usuario>>.CreateSuccessResult(result);
                else
                    return OperationResult<List<Usuario>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<List<Usuario>>.CreateFailure(ex);
            }


        }
        //----------------------------------------
        [HttpGet]
        public OperationResult<List<Usuario>> Usuarios()
        {

            try
            {
                var result = new UsuarioNegocio().Usuarios();
                if (result.Count() > 0)
                    return OperationResult<List<Usuario>>.CreateSuccessResult(result);
                else
                    return OperationResult<List<Usuario>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<List<Usuario>>.CreateFailure(ex);
            }


        }

        //insercion de usuarios

        [HttpPost]
        public OperationResult<int> InsertaUsuario(Usuario usuario)
        {
            try
            {
                var result = new UsuarioNegocio().InsertaUsuario(usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al crear teléfono estudiante");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }


        [HttpPut]
        public OperationResult<int> ActualizaUsuario(Usuario usuario)
        {
            try
            {
                var result = new UsuarioNegocio().ActualizaUsuario(usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al crear teléfono estudiante");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }

    }
}
