using Rega.Dto.Dtos;
using Rega.OfferFeature.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature.UseCases
{
    public class OfferUseCase : IOfferUseCase
    {
        private readonly IOfferService _offerService;
        public OfferUseCase(IOfferService offerService)
        {
            _offerService = offerService;
        }
        public ActiveOfferModel GetActiveOffer(int id)
        {
            var offerEntity = _offerService.GetActiveOfferByStaffId(id);
            
            ActiveOfferModel activeOffer = new ActiveOfferModel()
            {
                Id = offerEntity.Id,
                Name = offerEntity?.OfferName,
                OfferDateRange = $"Başlangıç Tarihi:{offerEntity.OfferStarDate.Value.ToShortDateString()} - Bitiş Tarihi : {offerEntity.OfferEndDate.Value.ToShortDateString()}",
                OfferResultMessage = offerEntity?.OfferMessage
            };

            return activeOffer;
        }
    }
}
