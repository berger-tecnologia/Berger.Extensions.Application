using Berger.Extensions.Pagination;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class BaseApplication<TSource, TDestination> : IBaseApplication<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
    {
        #region Properties
        public int Current { get; set; }
        public List<TSource> Items { get; set; }
        public int Limit { get; set; }
        public int Pages { get; set; }
        public int TotalCount { get; set; }
        public int Previous { get; set; }
        public int Next { get; set; }
        public IPageInformation PageInformation { get; set; }
        #endregion

        #region Methods
        public TSource Manage(TSource source)
        {
            return source.Id != Guid.Empty ? Update(source) : Add(source);
        }
        #endregion
    }
}
