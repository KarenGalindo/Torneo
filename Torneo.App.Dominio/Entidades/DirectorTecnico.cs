using System.ComponentModel.DataAnnotations;
namespace Torneo.App.Dominio
{
    public class DirectorTecnico
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del D.T.")]
        [Required(ErrorMessage = "El nombre del DT es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Numero de documento")]
        [Required(ErrorMessage = "El documento del DT es obligatorio")]
        public string Documento { get; set; }
        [Display(Name = "Numero de telefono")]
        [Required(ErrorMessage = "El telefono del DT es obligatorio")]
        public string Telefono { get; set; }
    }
}