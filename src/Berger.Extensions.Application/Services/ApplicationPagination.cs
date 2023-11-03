using Berger.Extensions.Pagination;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination> where TSource : class, IBaseInput where TDestination : class, IBaseEntity
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
        public IPagination<TSource> Get(int page = 0)
        {
            var results = _service.Get().Paginate(page, 50);

            return _mapper.Map<IPagination<TSource>>(results);
        }
        #endregion
    }
}