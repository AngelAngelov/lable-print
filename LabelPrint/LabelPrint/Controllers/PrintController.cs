using LabelPrint.Models;
using LabelPrint.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LabelPrint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrintController : ControllerBase
    {
        private readonly ClientService _service;

        public PrintController() 
        {
            _service = new ClientService();
        }

        [HttpPost]
        public IActionResult Print([FromForm] PicRequestModel model)
        {
            try
            {
                //Тук трябва да се извика услугата, която ще генерира файла
                var res = _service.Print(model.ClientId, model.Template);

                //След като получим картинката от услугата, тя трябва да се върне като резултат от заявката
                return File(res, "application/octet-stream", "ClientLabel.jpeg");
            }
            catch (Exception x)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, x);
            }
        }
    }
}
