using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Catalogo.Jogos.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch
            {
                await HandleExceptionAsync(context); // Poderia por aqui pra gravar os erros em logs, por exemplo, pra manter a rastreabilidade de erros na aplicação
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // Pode por o status code que quiser
            await context.Response.WriteAsJsonAsync(new { Message = "Ocorreu um erro durante sua solicitação, por favor, tente novamente mais tarde" });
        }
    }
}
