using FactoryInjection.Enums;
using FactoryInjection.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryInjection.Controllers
{
    /// <summary>
    /// 料件Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly IPartFactory _partFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        public PartController(IPartFactory partFactory) 
        {
            _partFactory = partFactory;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            object obj = new
            {
                PublicDatas = _partFactory.New(CloudServiceType.Public).Get(),
                PrivateDatas = _partFactory.New(CloudServiceType.Private).Get()
            };

            return Ok(obj);
        }

    }
}
