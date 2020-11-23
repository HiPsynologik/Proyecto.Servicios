using Proyecto.Servicios.Shared.Models;
using System.Collections.Generic;

namespace Proyecto.Servicios.Shared.ModelService
{
    public class OperationResponseBase<T>
    {
        public List<ErrorMessage> ErrorList { get; set; }

        public bool ValidExecution { get; set; }

        public T Item { get; set; }
    }
}
