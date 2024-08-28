using IncidentApiService.Services;
using IncidentApiService.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace IncidentApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequestSizeLimit(long.MaxValue)]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;
        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }
        [HttpGet]
        public string GetCount()
        {
            Console.WriteLine(");");
            return "Ardhendu";
        }
        [HttpPost]
        [MultipartFormData]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> UploadExcel()
        {
            var fileUploadSummary = await _fileService.UploadFileAsync(HttpContext.Request.Body, Request.ContentType);


            Console.WriteLine("uploaded.");
            return Ok(fileUploadSummary);
        }

    }
}
