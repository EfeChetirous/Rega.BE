using Rega.DataHandler.Entities;
using Rega.DataHandler.Repository;
using Rega.Dto.ApiReultModels;
using Rega.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OneToOneFeature.Services
{
    public class OneToOneService : IOneToOneService
    {
        private readonly IRepository<OneToOne> _oneToOneRepository;
        public OneToOneService(IRepository<OneToOne> oneToOneRepository) 
        {
            _oneToOneRepository = oneToOneRepository;
        }
        public Result SaveOneToOneMatch(OneToOne oneToOneModel)
        {
            try
            {
                _oneToOneRepository.Insert(oneToOneModel);
                return new SuccessResult(true,"Talebiniz Alınmıştır.");
            }
            catch (Exception ex)
            {
                return new FailureResult($"Hata ile karşılaşıldı! Ex : {ex.Message}");
            }
        }
    }
}
