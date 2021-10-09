using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio; 

namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListRutasModel : PageModel
    {
       private readonly RepositorioRutas RepositorioRutas;
        public IEnumerable <Rutas> LRutas { get; set;}
        [BindProperty]
        public Rutas Rutas { get; set;}

        public ListRutasModel(RepositorioRutas RepositorioRutas) 
        {
            this.RepositorioRutas = RepositorioRutas;
        }
        
        public void OnGet()
        { // From Flight Repositoy  get the flight from Data Base
            LRutas = RepositorioRutas.GetAll();
        }
        
        public IActionResult OnPost()
        {
      
            if(Rutas.id > 0)
            {
                RepositorioRutas.Delete(Rutas.id);
            }
            return RedirectToPage("./List");
        }

    }
}
