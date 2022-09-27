using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioDT : IRepositorioDT
    {
        private readonly DataContext _dataContext = new DataContext();
        
        public DirectorTecnico AddDT(DirectorTecnico directorTecnico)
        {
        var dtInsertado = _dataContext.DirectoresTecnicos.Add(directorTecnico);
        _dataContext.SaveChanges();
        return dtInsertado.Entity;
        }

        public IEnumerable<DirectorTecnico> GetAllDTs()
        {
            return _dataContext.DirectoresTecnicos;
        }

        public DirectorTecnico GetDT(int idDirectorTecnico)
        {
            return _dataContext.DirectoresTecnicos.Find(idDirectorTecnico);
        }

        public DirectorTecnico UpdateDT(DirectorTecnico directorTecnico)
        {
            var directorTecnicoEncontrado = _dataContext.DirectoresTecnicos.Find(directorTecnico.Id);
            if (directorTecnicoEncontrado != null)
            {
                directorTecnicoEncontrado.Nombre = directorTecnico.Nombre;
                directorTecnicoEncontrado.Documento = directorTecnico.Documento;
                directorTecnicoEncontrado.Telefono = directorTecnico.Telefono;
                _dataContext.SaveChanges();
            }
            return directorTecnicoEncontrado;
        }
    }
}