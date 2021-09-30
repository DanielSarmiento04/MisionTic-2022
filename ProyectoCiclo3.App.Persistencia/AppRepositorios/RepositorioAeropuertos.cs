using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> Aeropuertos;
 
        public RepositorioAeropuertos()
        {
            Aeropuertos = new List<Aeropuertos>()
            {
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id)
        {
            return Aeropuertos.SingleOrDefault(b => b.id == id);
        }
    }

}