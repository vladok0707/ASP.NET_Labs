using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    /// <summary>
    /// Сводное описание для CalculatorCallbackHandler
    /// </summary>
    public class CalculatorCallbackHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;

        // Вывести обычный текст
        response.ContentType = "text/plain";

        // Получить аргументы строки запроса        
        float value1, value2;
        if (Single.TryParse(context.Request.QueryString["value1"], out value1) &&
            Single.TryParse(context.Request.QueryString["value2"], out value2))
        {
            // Вычислить сумму
            response.Write(value1 + value2);
            response.Write(",");
               
        }
        else
        {
            // Значения не были предоставлены, или они не были числами.
            // Указать на ошибку
            response.Write("-");
        }
    }
 
    public bool IsReusable
    {
        get
        {
            return true;
        }
    }
    }
}