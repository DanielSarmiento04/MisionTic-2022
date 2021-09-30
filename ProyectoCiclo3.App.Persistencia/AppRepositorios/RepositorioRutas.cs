using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> Rutas;
 
        public RepositorioRutas()
        {
            Rutas = new List<Rutas>()
            {
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return Rutas;
        }
 
        public Rutas GetRutasWithId(int id)
        {
            return Rutas.SingleOrDefault(b => b.id == id);
        }
    }

}