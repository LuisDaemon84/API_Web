using API_King_Web.Models.Dto;

namespace API_King_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> ObtenerTodos<T>();
        Task<T> Obtener<T>(int id);
        Task<T> Crear<T>(VillaCreateDto dto);
        Task<T> Actualizar<T>(VillaUpdateDto dto);
        Task<T> Remover <T>(int id);
    }
}
