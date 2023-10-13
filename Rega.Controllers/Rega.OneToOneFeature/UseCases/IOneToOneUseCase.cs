using Rega.Dto.ApiReultModels;
using Rega.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.OneToOneFeature.UseCases
{
    public interface IOneToOneUseCase
    {
        Result SaveOneToOne(OneToOneStartModel oneToOneModel);
    }
}
