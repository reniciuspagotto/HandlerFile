using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace HandlerFile.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPdfFile()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\File\\file1.jpg";

            const string contentType = "application/jpg";
            var result = new FileContentResult(System.IO.File.ReadAllBytes(filePath), contentType)
            {
                FileDownloadName = $"file1.jpg"
            };

            return result;
        }

        [HttpPost]
        [Route("Action1")]
        public IActionResult Upload([FromForm]ObjectDto dto)
        {
            using (var stream = new MemoryStream())
            {
                dto.Files.CopyToAsync(stream);
                var base64String = Convert.ToBase64String(stream.ToArray());
            }

            return Ok("Arquivo recebido");
        }

        [HttpPost]
        [Route("Action2")]
        public IActionResult Upload2(IFormFile file, [FromForm]ObjectDto dto)
        {
            using (var stream = new MemoryStream())
            {
                file.CopyToAsync(stream);
                var base64String = Convert.ToBase64String(stream.ToArray());
            }

            return Ok("Arquivo recebido");
        }
    }
}