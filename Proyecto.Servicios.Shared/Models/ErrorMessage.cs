using System.Runtime.Serialization;

namespace Proyecto.Servicios.Shared.Models
{
    [DataContract]
    public class ErrorMessage
    {
        [DataMember]
        public string Description { get; set; }
    }
}
