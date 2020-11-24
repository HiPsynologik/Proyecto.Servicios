using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using System.ServiceModel;

namespace Proyecto.Servicios.Services
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        UsuarioFilterResponse ObtenerUsuario(UsuarioFilterRequest request);
    }
}
