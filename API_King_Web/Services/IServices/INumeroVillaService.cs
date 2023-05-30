using API_King_Web.Models.Dto;

namespace API_King_Web.Services.IServices
{
    public interface INumeroVillaService
    {
        Task<T> ObtenerTodos<T>();
        Task<T> Obtener<T>(int id);
        Task<T> Crear<T>(NumeroVillaCreateDto dto);
        Task<T> Actualizar<T>(NumeroVillaUpdateDto dto);
        Task<T> Remover <T>(int id);
    }
}
