using API_King.Modelos;
using API_King_Web.Models;

namespace API_King_Web.Services.IServices
{
    public interface IBaseService
    {
        public APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
