namespace ManagingRestaurant.Upload
{
    public interface IBufferedFileUploadService
    {
        Task<string> UploadFile(IFormFile file);
    }
}
