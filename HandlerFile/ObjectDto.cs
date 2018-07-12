using Microsoft.AspNetCore.Http;

namespace HandlerFile
{
    public class ObjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
    }
}
