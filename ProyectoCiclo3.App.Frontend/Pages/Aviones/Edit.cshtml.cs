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
    public class EditAvionesModel : PageModel
    {
        private readonly RepositorioAviones RepositorioAviones;
        [BindProperty]
        public Aviones Aviones {get;set;}
        // Constructor
        public EditAvionesModel(RepositorioAviones RepositorioAviones)
        {
            this.RepositorioAviones = RepositorioAviones;
        }
 
        public IActionResult OnGet(int AvionesId)
        {
            Aviones = RepositorioAviones.GetAvionesWithId(AvionesId);
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aviones.id > 0)
            {
            Aviones = RepositorioAviones.Update(Aviones);
            }
            return RedirectToPage("./List");;
        }
    }
}
