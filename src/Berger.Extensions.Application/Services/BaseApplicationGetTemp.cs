using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public class BaseApplicationGetTemp<T> : IBaseApplicationGet<T> where T : BaseEntity
    {
        private readonly List<T> _items;

        public BaseApplicationGetTemp(List<T> items)
        {
            _items = items;
        }
        public List<T> Get()
        {
            return _items;
        }

        public T GetById(Guid id)
        {
            return _items.FirstOrDefault(e => e.Id == id);
        }
    }
}