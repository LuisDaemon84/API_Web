using API_King_Web.Models.Dto;

namespace API_King_Web.Models.ViewModel
{
    public class VillaPaginadoViewModel
    {
        public int PageNumber { get; set; }
        public int TotalPaginas { get; set; }
        public string Previo { get; set; } = "disabled";
        public string Siguiente { get; set; } = "";
        public IEnumerable<VillaDto> VillaList { get; set; }
    }
}
