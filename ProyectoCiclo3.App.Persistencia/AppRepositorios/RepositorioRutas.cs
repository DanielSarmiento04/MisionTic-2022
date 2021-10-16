using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {   
        List<Rutas> Rutas;
        private readonly AppContext _appContext = new AppContext(); 

 
        public IEnumerable<Rutas> GetAll()
        {
            return _appContext.Rutas;
        }
 
        public Rutas GetRutasWithId(int id)
        {
            return _appContext.Rutas.Find(id);
        }
        
        public Rutas Create(Rutas newRutas)
        {
            var addRutas = _appContext.Rutas.Add(newRutas);
            _appContext.SaveChanges();
            return addRutas.Entity;
        }

        public void Delete(int id)
        {
            var Ruta = _appContext.Rutas.Find(id);
            if(Ruta ==null) return;
            _appContext.Rutas.Remove(Ruta);
            _appContext.SaveChanges();
        }
        
        public Rutas Update(Rutas newRutas){
            var Ruta = _appContext.Rutas.Find(newRutas.id);

            if(Ruta != null){
                Ruta.nombre = newRutas.nombre;
                Ruta.origen = newRutas.origen;
                Ruta.tiempoEsperado = newRutas.tiempoEsperado;
                _appContext.SaveChanges();
            }
            return Ruta    ;
        }

    }

}