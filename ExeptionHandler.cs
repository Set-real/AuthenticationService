using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AuthenticationService
{
    public class ExeptionHandler : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = "Произошла непридвиденная ошибка. Администрация сайта уже бежит на помощь!";

            if (context.Exception is CustomException) 
            { 
                message = context.Exception.Message;

                context.Result = new BadRequestObjectResult(message);
            }
        }
    }
}
