using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormAvionesModel : PageModel
    {
        public void OnGet()
        {
//  CLASE
        }
    }
}
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using ProyectoCiclo3.App.Persistencia.AppRepositorios;
// using ProyectoCiclo3.App.Dominio;
 
// namespace ProyectoCiclo3.App.Frontend.Pages
// {
//     public class FormAvionesModel : PageModel
//     {
//         private readonly RepositorioAviones RepositorioAviones;
//         [BindProperty]
//         public Aviones Aviones {get;set;}
//         // Constructor
//         public EditAvionesModel(RepositorioAviones RepositorioAviones)
//         {
//             this.RepositorioAviones = RepositorioAviones;
//         }
 
//         public IActionResult OnGet(int AvionesId){

//         }
//         public IActionResult OnPost()
//         {
//             if(!ModelState.IsValid)
//             {
//                 return Page();
//             }
//             Aviones = RepositorioAviones.Create(Aviones);
//             return RedirectToPage("./List");;
//         }
//     }
// }
