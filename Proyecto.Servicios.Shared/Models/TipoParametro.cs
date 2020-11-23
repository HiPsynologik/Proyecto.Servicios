using System.Runtime.Serialization;

namespace Proyecto.Servicios.Shared.Models
{
    [DataContract]
    public enum TipoParametro
    {
        [EnumMember]
        Int,
        [EnumMember]
        DateTime,
        [EnumMember]
        String,
        [EnumMember]
        Bool,
        [EnumMember]
        Decimal,
        [EnumMember]
        Double,
        [EnumMember]
        Long
    }
}
