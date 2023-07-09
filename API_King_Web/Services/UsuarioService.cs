using API_King_Utilidad;
using API_King_Web.Models;
using API_King_Web.Models.Dto;
using API_King_Web.Services.IServices;

namespace API_King_Web.Services
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        public readonly IHttpClientFactory _httpClient;
        private string _villaUrl;

        public UsuarioService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClient = httpClient;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:API_URL");
        }


        public Task<T> Login<T>(LoginRequestDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                APITipo = DS.APITipo.POST,
                Datos = dto,
                Url = _villaUrl + "/api/usuario/login"
            });
        }

        public Task<T> Registrar<T>(RegistroRequestDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                APITipo = DS.APITipo.POST,
                Datos = dto,
                Url = _villaUrl + "/api/usuario/registrar"
            });
        }
    }
}
