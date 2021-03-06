using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{


    // public class RepositorioAviones
    // {
    //     List<Aviones> Aviones;
 
    //     public RepositorioAviones()
    //     {
    //         Aviones = new List<Aviones>()
    //         {
    //             new Aviones {id = 1, marca = "MFG234", modelo = 2002, numero_asientos = 2, numero_banos = 4, capacidad_maxima = 9 },
    //             new Aviones {id = 2, marca = "Airbus", modelo = 2002, numero_asientos = 2, numero_banos = 4, capacidad_maxima = 9 }
    //         };
    //     }
 
    //     public IEnumerable<Aviones> GetAll()
    //     {
    //         return Aviones;
    //     }
 
    //     public Aviones GetAvionesWithId(int id)
    //     {
    //         return Aviones.SingleOrDefault(b => b.id == id);
    //     }

    //     // For create a flight
    //     public Aviones Create(Aviones newAviones)
    //     {
    //        if(Aviones.Count > 0){
    //         newAviones.id = Aviones.Max(r => r.id) +1; 
    //         }else{
    //            newAviones.id = 1; 
    //         }
    //        Aviones.Add(newAviones);
    //        return newAviones;
    //     }
    //     public Aviones Delete(int id)
    //     {
    //         var Avion= Aviones.SingleOrDefault(b => b.id == id);
    //         Aviones.Remove(Avion);
    //         return Avion;
    //     }
        
    //     public Aviones Update(Aviones newAviones){
    //         var Avion = Aviones.SingleOrDefault(b => b.id == newAviones.id);
    //         if(Avion != null){
    //             Avion.marca = newAviones.marca;
    //                 Avion.modelo = newAviones.modelo;
    //             Avion.numero_asientos = newAviones.numero_asientos;
    //             Avion.numero_banos = newAviones.numero_banos;
    //             Avion.capacidad_maxima = newAviones.capacidad_maxima;
    //         }
    //         return Avion    ;
    //     }
    // }
    public class RepositorioAviones
    {
        List<Aviones> Aviones;
        private readonly AppContext _appContext = new AppContext(); 
 
        public IEnumerable<Aviones> GetAll()
        {
            return _appContext.Aviones;
        }
 
        public Aviones GetAvionesWithId(int id)
        {
            return _appContext.Aviones.Find(id);;
        }
        
        public Aviones Update(Aviones newAviones){
            var Avion = _appContext.Aviones.Find(newAviones.id);

            if(Avion != null){
                Avion.marca = newAviones.marca;
                Avion.modelo = newAviones.modelo;
                Avion.numero_asientos = newAviones.numero_asientos;
                Avion.numero_banos = newAviones.numero_banos;
                Avion.capacidad_maxima = newAviones.capacidad_maxima;
                _appContext.SaveChanges();
            }
            return Avion    ;
        }

        // For create a flight
        public Aviones Create(Aviones newAviones)
        {
            var addAviones = _appContext.Aviones.Add(newAviones);
            _appContext.SaveChanges();
            return addAviones.Entity;
        }
    
        public void Delete(int id)
        {
            var Avion = _appContext.Aviones.Find(id);
            if (Avion == null)
                return;
            _appContext.Aviones.Remove(Avion);
            _appContext.SaveChanges();

        }

    }

}


