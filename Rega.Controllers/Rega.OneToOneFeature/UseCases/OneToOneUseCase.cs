using Rega.DataHandler.Entities;
using Rega.Dto.ApiReultModels;
using Rega.Dto.Dtos;
using Rega.OneToOneFeature.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OneToOneFeature.UseCases
{
    public class OneToOneUseCase : IOneToOneUseCase
    {
        private readonly IOneToOneService _oneToOneService;
        public OneToOneUseCase(IOneToOneService oneToOneService)
        {
            _oneToOneService = oneToOneService;
        }
        public Result SaveOneToOne(OneToOneStartModel oneToOneModel)
        {
            try
            {
                OneToOne entity = new OneToOne { DateCreated = DateTime.Now, FirstCompetitorId = oneToOneModel.FirstCompetitorId, SecondCompetatorId = oneToOneModel.SecondCompetitorId };
                var result = _oneToOneService.SaveOneToOneMatch(entity);
                return result;
            }
            catch
            {
                return new FailureResult();
            }
        }
    }
}
