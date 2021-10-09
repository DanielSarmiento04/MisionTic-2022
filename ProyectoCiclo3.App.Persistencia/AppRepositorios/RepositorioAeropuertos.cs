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
 
        public Aeropuertos GetAvionesWithId(int id)
        {
            return Aeropuertos.SingleOrDefault(b => b.id == id);
        }

        // For create a flight
        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
           if(Aeropuertos.Count > 0){
            newAeropuerto.id = Aeropuertos.Max(r => r.id) + 1; 
            }else{
               newAeropuerto.id = 1; 
            }
           Aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }
        // public Aviones Delete(int id)
        // {
        //     var Avion= Aviones.SingleOrDefault(b => b.id == id);
        //     Aviones.Remove(Avion);
        //     return Avion;
        // }
        
        // public Aviones Update(Aviones newAviones){
        //     var Avion = Aviones.SingleOrDefault(b => b.id == newAviones.id);
        //     if(Avion != null){
        //         Avion.marca = newAviones.marca;
        //         Avion.modelo = newAviones.modelo;
        //         Avion.numero_asientos = newAviones.numero_asientos;
        //         Avion.numero_banos = newAviones.numero_banos;
        //         Avion.capacidad_maxima = newAviones.capacidad_maxima;
        //     }
        //     return Avion    ;
        // }
    
        



        
    }

}