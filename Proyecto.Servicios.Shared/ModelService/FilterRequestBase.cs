using Proyecto.Servicios.Shared.Models;

namespace Proyecto.Servicios.Shared.ModelService
{
    public class FilterRequestBase<T>
    {
        public bool RequieredPagination { get; set; }

        public Pagination pagination { get; set; }

        public T Item { get; set; }
    }
}
