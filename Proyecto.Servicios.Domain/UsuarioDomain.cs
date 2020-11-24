using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.Domain
{
    public class UsuarioDomain : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
