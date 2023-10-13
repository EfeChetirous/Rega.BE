using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rega.Dto.ApiReultModels;
using Rega.Dto.Dtos;
using Rega.OneToOneFeature.UseCases;

namespace Rega.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneToOneController : ControllerBase
    {
        private readonly IOneToOneUseCase _oneToOneUseCase;
        public OneToOneController(IOneToOneUseCase oneToOneUseCase)
        {
            _oneToOneUseCase = oneToOneUseCase;
        }
        [HttpPost]
        [Route("PostOneToOneStart")]
        public Result PostOneToOneStart(OneToOneStartModel startModel)
        {
            var result = _oneToOneUseCase.SaveOneToOne(startModel);
            return result;
        }
    }
}
