using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace MCT.CCAlib.ClientControllers
{
    public class ClientControllerBase<T, U> : Controller where T : class where U : class
    {
        protected readonly ILogger<T> _logger;
        protected readonly U _service;
        protected readonly IMapper _mapper;

        public ClientControllerBase(ILogger<T> logger, U service, IMapper mapper)
        {
            _logger = logger;            
            _service = service;
            _mapper = mapper;
        }
    }
}
