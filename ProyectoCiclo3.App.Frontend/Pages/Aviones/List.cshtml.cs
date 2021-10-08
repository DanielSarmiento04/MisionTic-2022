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
        public IEnumerable <Aviones> LAviones { get; set;}
        [BindProperty]
        public Aviones Aviones { get; set;}

        public ListAvionesModel(RepositorioAviones RepositorioAviones) 
        {
            this.RepositorioAviones = RepositorioAviones;
        }
        
        public void OnGet()
        { // From Flight Repositoy  get the flight from Data Base
            LAviones = RepositorioAviones.GetAll();
        }
        
        public IActionResult OnPost()
        {
      
            if(Aviones.id > 0)
            {
                RepositorioAviones.Delete(Aviones.id);
            }
            return RedirectToPage("./List");
        }

    }
}
