using static API_King_Utilidad.DS;

namespace API_King_Web.Models
{
    public class APIRequest
    {
        public APITipo APITipo { get; set; } = APITipo.GET;
        public string Url { get; set; }
        public object Datos { get; set; }
        public string Token { get; set; }
        public Parametros Parametros { get; set; }
    }

    public class Parametros
    {
        public int PageNumber { set; get; }
        public int PageSize { set; get; }
    }
}
