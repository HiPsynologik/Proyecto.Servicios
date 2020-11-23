using Proyecto.Servicios.Shared.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Proyecto.Servicios.Shared.ModelService
{
    [DataContract]
    public class EmptyResponse
    {
        [DataMember]
        public List<ErrorMessage> ErrorList { get; set; }

        [DataMember]
        public bool ValidaExecition { get; set; }

        [DataMember]
        public object Result { get; set; }

        [DataMember]
        public TipoParametro TipoDato { get; set; }
    }
}
