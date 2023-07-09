using API_King_Web.Models.Dto;

namespace API_King_Web.Services.IServices
{
    public interface IUsuarioService
    {
        Task<T> Login<T>(LoginRequestDto dto);
        Task<T> Registrar<T>(RegistroRequestDto dto);
    }
}
