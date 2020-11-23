using System.Runtime.Serialization;

namespace Proyecto.Servicios.Shared.Models
{
    [DataContract]
    public class Pagination
    {
        [DataMember]
        public int Page { get; set; }

        [DataMember]
        public int Records { get; set; }

        [DataMember]
        public long TotalRecords { get; set; }
    }
}
