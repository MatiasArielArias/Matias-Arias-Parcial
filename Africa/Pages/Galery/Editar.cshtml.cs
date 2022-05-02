using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Africa.Modelo;
using Africa.Servicios;

namespace MyApp.Namespace
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Ropa RopaEditar { get; set; }
        private IRopaServicio _ropaServicio;

        public EditarModel(IRopaServicio ropaServicio)
        {
            _ropaServicio = ropaServicio;
        }
        public void OnGet(int id)
        {
            RopaEditar = _ropaServicio.MostrarTodos().Where(x => x.ID == id).First();
        }
        public IActionResult OnPost()
        {
            _ropaServicio.Modificar(RopaEditar);
            return RedirectToPage("Galeria");
        }
    }
}
