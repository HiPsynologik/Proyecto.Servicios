using Proyecto.Servicios.Shared.Models;
using System.Collections.Generic;

namespace Proyecto.Servicios.Shared.ModelService
{
    public class FilterResponseBase<T>
    {
        public List<ErrorMessage> ErrorList { get; set; }

        public List<T> List { get; set; }

        public bool ValidaExecution { get; set; }

        public Pagination pagination { get; set; }
    }
}
