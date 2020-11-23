using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using System;

namespace Proyecto.Servicios.Services
{
    public class Service : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public UsuarioFilterResponse ObtenerUsuario(UsuarioFilterRequest request)
        {
            UsuarioFilterResponse response = new UsuarioFilterResponse();

            return response;
        }
    }
}
