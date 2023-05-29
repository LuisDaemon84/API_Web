using static API_King_Utilidad.DS;

namespace API_King_Web.Models
{
    public class APIRequest
    {
        public APITipo APITipo { get; set; } = APITipo.GET;
        public string Url { get; set; }
        public object Datos { get; set; }
    }
}
