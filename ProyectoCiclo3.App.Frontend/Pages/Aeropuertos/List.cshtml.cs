using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{

    public class ListAeropuertosModel : PageModel
    {
        public void OnGet()
        {
 
        }
    }
    // public class ListAeropuertosModel : PageModel
    // {
    //     private readonly RepositorioAeropuertos RepositorioAeropuertos;
    //     public IEnumerable <Aeropuertos> Aeropuertos { get; set;}
    //     [BindProperty]
    //     public Aeropuertos Aeropuerto { get; set;}

    //     public ListAeropuertosModel(RepositorioAeropuertos RepositorioAeropuertos) 
    //     {
    //         this.RepositorioAeropuertos = RepositorioAeropuertos;
    //     }
        
    //     public void OnGet()
    //     { // From Flight Repositoy  get the flight from Data Base
    //         Aeropuertos = RepositorioAeropuertos.GetAll();
    //     }
        
    //     public IActionResult OnPost()
    //     {
    //         if(Aeropuerto.id > 0)
    //         {
    //            Aeropuerto = RepositorioAeropuertos.Delete(Aeropuerto.id);
    //         }
    //         return RedirectToPage("./List");
    //     }
    // }
}
