using System;
using System.Runtime.Serialization;

namespace Proyecto.Servicios.Model.ViewModels
{
    [DataContract]
    public class Usuarios
    {
        [DataMember]
        public int Id_Usuario { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Ap_Paterno { get; set; }

        [DataMember]
        public string Ap_Materno { get; set; }

        [DataMember]
        public string Imagen { get; set; }

        [DataMember]
        public string Correo { get; set; }

        [DataMember]
        public DateTime FechaCreacion { get; set; }

        [DataMember]
        public bool Estatus { get; set; }
    }
}
