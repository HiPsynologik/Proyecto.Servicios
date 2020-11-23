using Proyecto.Servicios.Model.Service.Request;
using Proyecto.Servicios.Model.Service.Response;
using System.ServiceModel;

namespace Proyecto.Servicios.Services
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        UsuarioFilterResponse ObtenerUsuario(UsuarioFilterRequest request);
    }
}
