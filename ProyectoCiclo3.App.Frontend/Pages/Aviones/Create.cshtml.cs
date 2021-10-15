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
    public class FormAvionesModel : PageModel
    {
        private readonly RepositorioAviones RepositorioAviones;
        private readonly RepositorioRutas RepositorioRutas;
        public IEnumerable<Aviones> LAviones {get;set;}
        public IEnumerable<Rutas> LRutas {get;set;}
        // la ultima 
        [BindProperty]
        public Aviones Aviones {get;set;}
        // Constructor
        public FormAvionesModel(RepositorioAviones RepositorioAviones,RepositorioRutas RepositorioRutas)
        {
            this.RepositorioAviones = RepositorioAviones;
            this.RepositorioRutas = RepositorioRutas;
        }

        public void OnGet(){
            LRutas = RepositorioRutas.GetAll();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Aviones = RepositorioAviones.Create(Aviones);
            return RedirectToPage("./List");;
        }

    }
}
