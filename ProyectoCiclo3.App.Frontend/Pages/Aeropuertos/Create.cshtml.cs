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
    public class FormAeropuertosModel : PageModel
    {
        private readonly RepositorioAeropuertos RepositorioAeropuertos;
        [BindProperty]
        public Aeropuertos Aeropuerto { get; set;}

        public  FormAeropuertosModel(RepositorioAeropuertos RepositorioAeropuertos){
            this.RepositorioAeropuertos = RepositorioAeropuertos;
        }
        

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Aeropuerto = RepositorioAeropuertos.Create(Aeropuerto);
            return RedirectToPage("./List");
        }
    }
}
