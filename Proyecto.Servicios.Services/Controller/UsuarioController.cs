using Proyecto.Servicios.IDomain;
using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using Proyecto.Servicios.Shared.Controllers;
using Proyecto.Servicios.Shared.Models;
using System;
using System.Collections.Generic;
using Vitamedica.Base.Factory;

namespace Proyecto.Servicios.Services.Controller
{
    public class UsuarioController : ControllerBase
    {
        public override List<ErrorMessage> ValidateFilterRequest<TFilterRequest, TFilterModel>(TFilterRequest request)
        {
            //List<ErrorMessage> listaErrores = new List<ErrorMessage>();

            //if (request.RequieredPagination && request.pagination == null)
            //{
            //    listaErrores.Add(new ErrorMessage() { Description =  "" });
            //}
            //else if (!request.RequieredPagination)
            //{
            //    request.pagination = null;
            //}

            //if(typeof(TFilterModel) == typeof())

            //return listaErrores;
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
                using (IUsuarioDomain domain = FactoryEngine<IUsuarioDomain>.GetInstance("IUsuarioDomain"))
                {
                    response.Item = domain.ObtenerUsuario(request.Item);
                    response.ValidExecution = true;
                }
            }
            catch (Exception ex)
            {
                response.ErrorList.Add(new ErrorMessage { Description = ex.Message });
            }

            return response;
        }
    }
}