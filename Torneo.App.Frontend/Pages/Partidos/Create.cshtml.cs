using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.PagesPartidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        
        public CreateModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }

        public void OnGet()
        {
            partido = new Partido();
        }

        public IActionResult OnPost(Partido partido, int idLocal, int idVisitante)
        {
            _repoPartido.AddPartido(partido, idLocal, idVisitante);
            return RedirectToPage("Index");
        }
    }
}
