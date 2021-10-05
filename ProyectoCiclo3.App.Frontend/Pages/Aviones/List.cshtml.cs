using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// Referencias de Persistencia
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio; 

namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListAvionesModel : PageModel
    {
        private readonly RepositorioAviones RepositorioAviones;
        public IEnumerable <Aviones> Aviones { get; set;}
        [BindProperty]
        public Aviones Avion { get; set;}

        public ListAvionesModel(RepositorioAviones RepositorioAviones) 
        {
            this.RepositorioAviones = RepositorioAviones;
        }
        
        public void OnGet()
        { // From Flight Repositoy  get the flight from Data Base
            Aviones = RepositorioAviones.GetAll();
        }
        
        public IActionResult OnPost()
        {
            if(Avion.id > 0)
            {
               Avion = RepositorioAviones.Delete(Avion.id);
            }
            return RedirectToPage("./List");
        }

    }
}
