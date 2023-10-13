using Rega.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OfferFeature.UseCases
{
    public interface IOfferUseCase
    {
        ActiveOfferModel GetActiveOffer(int id);
    }
}
