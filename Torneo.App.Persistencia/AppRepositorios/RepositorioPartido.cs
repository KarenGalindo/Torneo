using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly DataContext _dataContext = new DataContext();
        
        public Partido AddPartido(Partido partido, int idLocal, int idVisitante)
        {
            var LocalEncontrado = _dataContext.Equipos.Find(idLocal);
            var VisitanteEncontrado = _dataContext.Equipos.Find(idVisitante);
            partido.Local = LocalEncontrado;
            partido.Visitante = VisitanteEncontrado;
            var partidoInsertado = _dataContext.Partidos.Add(partido);
            _dataContext.SaveChanges();
            return partidoInsertado.Entity;
        }

        public IEnumerable<Partido> GetAllPartidos()
        {
            return _dataContext.Partidos;
        }

        public Partido GetPartido(int idPartido)
        {
            var partidoEncontrado = _dataContext.Partidos.Find(idPartido);
            return partidoEncontrado;
        }

        public Partido UpdatePartido(Partido partido, int idLocal, int idVisitante)
        {
            var partidoInsertado = GetPartido(partido.Id);
            var LocalEncontrado = _dataContext.Equipos.Find(idLocal);
            var VisitanteEncontrado = _dataContext.Equipos.Find(idVisitante);
            partido.Local = LocalEncontrado;
            partido.Visitante = VisitanteEncontrado;
            _dataContext.SaveChanges();
            return partidoInsertado;
        }
    }
}