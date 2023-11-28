using AutoMapper;
using Berger.Extensions.Pagination;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public partial class ApplicationService<TSource, TDestination> : IApplicationService<TSource, TDestination>
        where TSource : BaseEntity
        where TDestination : BaseEntity
    {
        #region Properties
        private readonly IMapper _mapper;
        private readonly IBaseService<TDestination> _service;
        #endregion

        #region Constructors
        public ApplicationService(IMapper mapper, IBaseService<TDestination> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion

        #region Methods
        public IPagination<TSource> Get(int page = 0)
        {
            var results = _service.Get().Paginate(page, 50);

            return _mapper.Map<IPagination<TSource>>(results);
        }
        public List<TSource> Get()
        {
            var results = _service.Get();

            return _mapper.Map<List<TSource>>(results);
        }
        public TSource GetById(Guid id)
        {
            var result = _service.GetById(id);

            return _mapper.Map<TSource>(result);
        }
        #endregion
    }
}