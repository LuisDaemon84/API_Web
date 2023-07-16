using API_King.Modelos;
using API_King.Modelos.Dto;
using Microsoft.Win32;

namespace API_King.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        bool IsUsuarioUnico(string userName);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginResquestDTO);
        Task<UsuarioDto> Registrar(RegistroRequestDTO registroRequestDTO);
    }
}
