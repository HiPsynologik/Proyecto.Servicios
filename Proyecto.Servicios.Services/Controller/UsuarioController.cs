using Proyecto.Servicios.IDomain;
using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using Proyecto.Servicios.Shared.Controllers;
using Proyecto.Servicios.Shared.Models;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios.Services.Controller
{
    public class UsuarioController : ControllerBase
    {
        public override List<ErrorMessage> ValidateFilterRequest<TFilterRequest, TFilterModel>(TFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public override List<ErrorMessage> ValidateOperationRequest<TOperationRequest, TModel>(TOperationRequest request)
        {
            throw new NotImplementedException();
        }

        internal UsuarioFilterResponse ObtenerUsuario(UsuarioFilterRequest request)
        {
            UsuarioFilterResponse response = new UsuarioFilterResponse();
            response.ErrorList = new List<ErrorMessage>();

            try
            {
                //using (IUsuarioDomain domain = FactoryEngine<IUsuarioDomain>.GetInstance("IUsuarioDomain"))
                //{

                //}
            }
            catch (Exception ex)
            {

            }

            return response;
        }
    }
}