using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Municipios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> municipios { get; set; }
        public bool ErrorEliminar { get; set; }

        public IndexModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet()
        {
            municipios = _repoMunicipio.GetAllMunicipios();
            ErrorEliminar = false;
        }

        public IActionResult OnPostDelete(int id)
        {
            try
            {
                municipios = _repoMunicipio.GetAllMunicipios();
                _repoMunicipio.DeleteMunicipio(id);
                return Page();
            }
            catch (Exception ex)
            {
                municipios = _repoMunicipio.GetAllMunicipios();
                ErrorEliminar = true;
                return Page();
            }
        }
    }
}
