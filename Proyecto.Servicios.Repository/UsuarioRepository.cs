using Proyecto.Servicios.IRepository;
using Proyecto.Servicios.Model.Filters;
using Proyecto.Servicios.Model.ViewModels;
using Proyecto.Servicios.Shared.DbServer;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios.Repository
{
    class UsuarioRepository : IUsuarioRepository
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Usuarios ObtenerUsuario(UsuarioFilter request)
        {
            Usuarios model = new Usuarios();
            List<DbParameterItem> parameter = new List<DbParameterItem>();

            parameter.Add(new DbParameterItem("@USERNAME", request.UserName));
            parameter.Add(new DbParameterItem("@PASSWORD", request.Password));

            using (SqlDbHelper helper = new SqlDbHelper(""))
            {
                var reader = helper.ExecuteReader("SP_CONSULTA_USUARIOS");
                while (reader.Read())
                {
                    model = new Usuarios()
                    {
                        Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                        Password = reader.GetString(reader.GetOrdinal("Password")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Ap_Paterno = reader.GetString(reader.GetOrdinal("Ap_Paterno")),
                        Ap_Materno = reader.GetString(reader.GetOrdinal("Ap_Materno")),
                        Imagen = reader.GetString(reader.GetOrdinal("Imagen")),
                        Correo = reader.GetString(reader.GetOrdinal("Correo")),
                        FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                        Estatus = !reader.IsDBNull(reader.GetOrdinal("Estatus")) && reader.GetBoolean(reader.GetOrdinal("Estatus"))
                    };
                }
                reader.Close();
            }

            return model;
        }
    }
}
