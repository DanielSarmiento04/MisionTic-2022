using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Dominio;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;

namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormRutasModel : PageModel
    {
        private readonly RepositorioAviones RepositorioAviones;
        private readonly RepositorioRutas RepositorioRutas;
        public IEnumerable<Aviones> LAviones {get;set;}
        public IEnumerable<Rutas> lRutas {get;set;}
        [BindProperty]
        public Rutas Rutas {get;set;}
        // Constructor
        public FormRutasModel(RepositorioRutas RepositorioRutas,RepositorioAviones RepositorioAviones)
        {
            this.RepositorioRutas = RepositorioRutas;
            this.RepositorioAviones = RepositorioAviones;
        }

        public void OnGet(){
            LAviones = RepositorioAviones.GetAll();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Rutas = RepositorioRutas.Create(Rutas);
            return RedirectToPage("./List");;
        }

    }
}
