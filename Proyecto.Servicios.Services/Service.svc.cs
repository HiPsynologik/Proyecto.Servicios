using Proyecto.Servicios.Model.Filters;
using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using Proyecto.Servicios.Services.Controller;
using System;

namespace Proyecto.Servicios.Services
{
    public class Service : IService
    {
        public UsuarioFilterResponse ObtenerUsuario(UsuarioFilterRequest request)
        {
            UsuarioFilterResponse response = new UsuarioFilterResponse();

            using (UsuarioController controller = new UsuarioController())
            {
                response.ErrorList = controller.ValidateFilterRequest<UsuarioFilterRequest, UsuarioFilter>(request);
                if (response.ErrorList.Count == 0)
                    response = controller.ObtenerUsuario(request);
            }

            return response;
        }
    }
}
