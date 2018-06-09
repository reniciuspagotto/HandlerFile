using Microsoft.AspNetCore.Mvc;

namespace HandlerFile.Controllers
{
    [Route("api/file")]
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
    }
}