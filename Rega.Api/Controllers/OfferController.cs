using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Rega.Dto.Dtos;
using Rega.OfferFeature.UseCases;

namespace Rega.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfferController : ControllerBase
    {
        private readonly IOfferUseCase _offerUseCase;
        public OfferController(IOfferUseCase offerUseCase)
        {
            _offerUseCase = offerUseCase;
        }

        [HttpGet]
        [Route("GetActiveOffer")]
        public ActiveOfferModel GetActiveOffer(int id)
        {
            var offer = _offerUseCase.GetActiveOffer(id);
            return offer;
        }
    }
}
