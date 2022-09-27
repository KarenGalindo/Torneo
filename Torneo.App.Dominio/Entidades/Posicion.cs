using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class Posicion
    {
        public int Id { get; set; }
        [Display(Name = "Nombre de la posicion")]
        [Required(ErrorMessage = "El nombre de la posicion es obligatorio")]
        public string Nombre { get; set; }
    }
}
