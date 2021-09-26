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
    }

}
