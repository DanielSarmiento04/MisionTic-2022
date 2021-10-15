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
    public class EditRutasModel : PageModel
    {
        private readonly RepositorioRutas RepositorioRutas;
        [BindProperty]
        public Rutas Rutas {get;set;}
        // Constructor
        public EditRutasModel(RepositorioRutas RepositorioRutas)
        {
            this.RepositorioRutas = RepositorioRutas;
        }
 
        public IActionResult OnGet(int RutasId)
        {
            Rutas = RepositorioRutas.GetRutasWithId(RutasId);
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Rutas.id > 0)
            {
                Rutas = RepositorioRutas.Update(Rutas);
            }
            return RedirectToPage("./List");;
        }
    }
}
