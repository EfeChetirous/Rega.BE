using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.Dto.ApiReultModels
{
    public class SuccessResult :Result
    {
        public SuccessResult(object Root, string Message) : base(true, Root, Message, ResultCodeEnum.Success)
        {
        }
    }
}
