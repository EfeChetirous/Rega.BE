using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.Dto.ApiReultModels
{
    public class FailureResult : Result
    {

        public FailureResult() : base(false, null, "İşlem sırasında beklenmedik bir hata oluştu!", ResultCodeEnum.Failure)
        {

        }

        public FailureResult(string message) : base(false, null, message, ResultCodeEnum.Failure)
        {

        }
        public FailureResult(List<string> messageList) : base(false, null, "İşlem sırasında bir hata oluştu.", messageList, ResultCodeEnum.Failure)
        {

        }

        public FailureResult(ResultCodeEnum resultCodeEnum) : base(false, null, "İşlem sırasında beklenmedik bir hata oluştu!", resultCodeEnum)
        {

        }
    }
}
