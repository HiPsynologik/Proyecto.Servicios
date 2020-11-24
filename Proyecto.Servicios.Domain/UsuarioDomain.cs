using Proyecto.Servicios.IRepository;
using Proyecto.Servicios.Model.Filters;
using Proyecto.Servicios.Model.ViewModels;
using System;
using Vitamedica.Base.Factory;

namespace Proyecto.Servicios.Domain
{
    public class UsuarioDomain : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        Usuarios ObtenerUsuario(UsuarioFilter request)
        {
            Usuarios result = new Usuarios();
            using (IUsuarioRepository Repository = FactoryEngine<IUsuarioRepository>.GetInstance("IUsuarioRepository"))
            {
                result = Repository.ObtenerUsuario(request);
            }

            return result;
        }
    }
}
