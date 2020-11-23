using Proyecto.Servicios.Shared.Models;
using System.Runtime.Serialization;

namespace Proyecto.Servicios.Shared.ModelService
{
    [DataContract]
    public class EmptyRequest
    {
        [DataMember]
        public object Param { get; set; }

        [DataMember]
        public TipoParametro TipoDato { get; set; }
    }
}
