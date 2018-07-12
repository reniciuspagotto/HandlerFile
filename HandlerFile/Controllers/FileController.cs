using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public IActionResult Upload([FromForm]ObjectDto dto)
        {
            var file = dto.File;
            return Ok("Arquivo recebido");
        }
    }
}