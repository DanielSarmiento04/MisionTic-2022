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
                new Rutas {id = 1, nombre = "MFG234", origen = "e", tiempoEsperado = "8"},
                new Rutas {id = 2, nombre = "Airbus", origen = "e", tiempoEsperado = "8"}
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
        
        public Rutas Create(Rutas newRutas)
        {
           if(Rutas.Count > 0){
            newRutas.id = Rutas.Max(r => r.id) +1; 
            }else{
               newRutas.id = 1; 
            }
           Rutas.Add(newRutas);
           return newRutas;
        }

        public Rutas Delete(int id)
        {
            var Ruta= Rutas.SingleOrDefault(b => b.id == id);
            Rutas.Remove(Ruta);
            return Ruta;
        }
        
        public Rutas Update(Rutas newRutas){
            var Ruta = Rutas.SingleOrDefault(b => b.id == newRutas.id);
            if(Ruta != null){
                Ruta.nombre = newRutas.nombre;
                Ruta.origen = newRutas.origen;
                Ruta.tiempoEsperado = newRutas.tiempoEsperado;
            }
            return Ruta    ;
        }

    }

}