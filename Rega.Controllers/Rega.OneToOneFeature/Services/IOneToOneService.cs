using Rega.DataHandler.Entities;
using Rega.Dto.ApiReultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OneToOneFeature.Services
{
    public interface IOneToOneService
    {
        Result SaveOneToOneMatch(OneToOne oneToOneModel);
    }
}
