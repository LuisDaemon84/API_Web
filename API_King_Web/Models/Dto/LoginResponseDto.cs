using System.Security.Policy;

namespace API_King_Web.Models.Dto
{
    public class LoginResponseDto
    {
        public UsuarioDto Usuario { get; set; }
        public string Token { get; set; }   
    }
}
