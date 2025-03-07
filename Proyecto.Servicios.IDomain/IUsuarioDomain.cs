﻿using Proyecto.Servicios.Model.Filters;
using Proyecto.Servicios.Model.ViewModels;
using System;

namespace Proyecto.Servicios.IDomain
{
    public interface IUsuarioDomain : IDisposable
    {
        Usuarios ObtenerUsuario(UsuarioFilter request);
    }
}
