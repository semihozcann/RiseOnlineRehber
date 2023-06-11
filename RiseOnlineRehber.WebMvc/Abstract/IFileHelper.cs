using Microsoft.AspNetCore.Http;

namespace RiseOnlineRehber.WebMvc.Abstract
{
    public interface IFileHelper
    {
        void DeleteFile(string imageUrl);
        string UploadFile(IFormFile file);

    }
}
