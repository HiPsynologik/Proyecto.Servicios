using Proyecto.Servicios.Model.Filters;
using Proyecto.Servicios.Model.ViewModels;
using System;

namespace Proyecto.Servicios.IRepository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuarios ObtenerUsuario(UsuarioFilter request);
    }
}
