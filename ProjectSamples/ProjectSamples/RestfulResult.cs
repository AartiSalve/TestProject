//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Net;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//namespace ProjectSamples
//{
//    public class RestfulResult<TValue> : ObjectResult
//    {
//        private readonly static ILogger<RestfulResult<TValue>> _logger = Ecp.Core.DependencyManager.GetInstance<ILogger<RestfulResult<TValue>>>();

//        public Result<TValue> Result { get; }
//        public bool IsSuccess => Result.IsSuccess;
//        public int ResultCode => Result.ResultCode;

//        /// <summary>
//        /// Initializes a new instance of <see cref="RestfulResult{TValue}"/> using the specified <paramref name="value"/>.
//        /// </summary>
//        /// <param name="value">The value.</param>
//        public RestfulResult(Result<TValue> value) : base(value.Data)
//        {
//            Result = value;
//            DeclaredType = typeof(TValue);

//            if (!Result.IsSuccess)
//            {
//                StatusCode = (int)HttpStatusCode.InternalServerError;
//                _logger.LogError("Request failed with Status:{status} and ResultCode:{errorCode}", StatusCode, Result.ResultCode);
//            }
//        }

//        public override void OnFormatting(ActionContext context)
//        {
//            base.OnFormatting(context);
//            if (!Result.IsSuccess)
//            {
//                var response = context.HttpContext.Response;
//                ResponseUtils.AddErrorHeader(response, Result.ResultCode);

//                if (Value == null || Equals(Value, string.Empty))
//                {
//                    ResponseUtils.WriteErrorCode(response, ResultCode);
//                }
//            }
//        }

//        public static implicit operator RestfulResult<TValue>(Result<TValue> value)
//        {
//            return new RestfulResult<TValue>(value);
//        }
//    }
//}