using Rega.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature.UseCases
{
    public class OfferUseCase : IOfferUseCase
    {
        public ActiveOfferModel GetActiveOffer()
        {
            //dummy data
            ActiveOfferModel activeOffer = new ActiveOfferModel()
            {
                Id = 1,
                Name = "Kredi Satış Teklifi!",
                OfferDateRange = "Başlangıç Tarihi: 2023-09-01 - Bitiş Tarihi : 2023-09-30",
                OfferResultMessage = "Yukarıda belirtilen tarih aralıklarında 15 kredi satışı hedefi size atanmıştır. Başarılar dileriz."
            };

            return activeOffer;
        }
    }
}
