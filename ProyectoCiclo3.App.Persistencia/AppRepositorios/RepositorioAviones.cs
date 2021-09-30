using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> Aviones;
 
        public RepositorioAviones()
        {
            Aviones = new List<Aviones>()
            {
                new Aviones {id = 1, marca = "MFG234", modelo = 2002, numero_asientos = 2, numero_banos = 4, capacidad_maxima = 9 },
                new Aviones {id = 2, marca = "Airbus", modelo = 2002, numero_asientos = 2, numero_banos = 4, capacidad_maxima = 9 }
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return Aviones;
        }
 
        public Aviones GetAvionesWithId(int id)
        {
            return Aviones.SingleOrDefault(b => b.id == id);
        }
        
        public Aviones Update(Aviones newAviones){
            var Avion = Aviones.SingleOrDefault(b => b.id == newAviones.id);
            if(Avion != null){
                Avion.marca = newAviones.marca;
                Avion.modelo = newAviones.modelo;
                Avion.numero_asientos = newAviones.numero_asientos;
                Avion.numero_banos = newAviones.numero_banos;
                Avion.capacidad_maxima = newAviones.capacidad_maxima;
            }
        return Avion    ;
        }

    }

}