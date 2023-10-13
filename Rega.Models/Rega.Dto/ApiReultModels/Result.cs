using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.Dto.ApiReultModels
{
    public class Result
    {
        public bool Success { get; private set; }
        public object Root { get; private set; }
        public string Message { get; private set; }
        public List<string> MessageList { get; private set; }
        public ResultCodeEnum ResultCodeEnum { get; private set; }

        public Result()
        {
            Success = false;
        }

        public Result(bool Success)
        {
            this.Success = Success;
        }

        protected Result(bool success, object root, string message, ResultCodeEnum resultCodeEnum)
        {
            this.Success = success;
            this.Root = root;
            this.Message = message;
            this.ResultCodeEnum = resultCodeEnum;
        }
        protected Result(bool success, object root, string message, List<string> messageList, ResultCodeEnum resultCodeEnum)
        {
            this.Success = success;
            this.Root = root;
            this.Message = message;
            this.ResultCodeEnum = resultCodeEnum;
            this.MessageList = messageList;
        }
    }

    public enum ResultCodeEnum
    {
        Success,
        Failure
    }
}
