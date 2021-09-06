using LabelPrint.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabelPrint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintController : ControllerBase
    {
        private readonly ClientService _service;

        public PrintController() 
        {
            _service = new ClientService();
        }

        [HttpPost]
        public IActionResult Print()
        {
            try
            {
                //Тук трябва да се извика услугата, която ще генерира файла
                //var res = _service. ....

                //След като получим картинката от услугата, тя трябва да се върне като резултат от заявката
                return Ok();
            }
            catch (Exception x)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, x);
            }
        }
    }
}
