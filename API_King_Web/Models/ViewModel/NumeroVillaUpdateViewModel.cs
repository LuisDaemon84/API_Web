using API_King_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace API_King_Web.Models.ViewModel
{
    public class NumeroVillaUpdateViewModel
    {
        public NumeroVillaUpdateViewModel()
        {
            NumeroVilla = new NumeroVillaUpdateDto();
        }
        public NumeroVillaUpdateDto NumeroVilla { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }  
    }
}
