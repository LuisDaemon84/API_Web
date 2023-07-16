using Microsoft.AspNetCore.Identity;

namespace API_King.Modelos
{
    public class UsuarioAplicacion: IdentityUser
    {
        public string Nombres { get; set; }
    }
}
