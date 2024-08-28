
namespace IncidentApiService.Services
{
    public interface IFileService
    {
        Task<string> UploadFileAsync(Stream fileStream, string contentType);
    }
}
