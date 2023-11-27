using AutoMapper;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Application
{
    public class BaseApplicationGet<T> : IBaseApplicationGet<T>
    {
        #region Constructors
        public BaseApplicationGet(IMapper mapper, IBaseService<T> service)
        {
            _mapper = mapper;
            _service = service;
        }
        #endregion

        #region Properties
        private readonly IMapper _mapper;
        private readonly IBaseService<T> _service;
        #endregion

        #region Methods
        public List<T> Get()
        {
            var results = _service.Get();

            return _mapper.Map<List<T>>(results);
        }
        public T GetById(Guid id)
        {
            var result = _service.GetById(id);

            return _mapper.Map<T>(result);
        }
        #endregion
    }
}