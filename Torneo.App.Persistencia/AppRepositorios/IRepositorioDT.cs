using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioDT
    {
        public DirectorTecnico AddDT(DirectorTecnico directorTecnico);
        public IEnumerable<DirectorTecnico> GetAllDTs();
        public DirectorTecnico GetDT(int idDirectorTecnico);
        public DirectorTecnico UpdateDT(DirectorTecnico directorTecnico);
        //public DirectorTecnico DeleteDT(int idDirectorTecnico);
    }
}