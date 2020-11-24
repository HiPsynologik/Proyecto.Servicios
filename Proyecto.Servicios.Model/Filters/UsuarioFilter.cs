using System.Runtime.Serialization;

namespace Proyecto.Servicios.Model.Filters
{
    [DataContract]
    public class UsuarioFilter
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
