﻿using Microsoft.AspNetCore.Mvc;
using Sakany.Shared.Responses;

namespace ECommerceAPI.Presentation.Controllers.Errors
{
    [Route("Api/V{version:apiVersion}/[controller]/{code}")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : ControllerBase
    {
        public IActionResult Error(int code)
        {
            var responseHandler = new ResponseHandler();

            return code switch
            {
                401 => Unauthorized(responseHandler.Unauthorized<object>("Unauthorized or invalid token")),
                404 => NotFound(responseHandler.NotFound<object>("Resource Not Found")),
                _ => StatusCode(code, responseHandler.ServerError<object>("An unexpected error occurred"))
            };
        }
    }
}