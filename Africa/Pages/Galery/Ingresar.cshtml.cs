using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Africa.Servicios;
using Africa.Modelo;

namespace Africa.Pages
{
    public class IngresarModel : PageModel
    {
        [BindProperty]
        public Ropa RopaNuevo { get; set; }
        private IRopaServicio _ropaServicio;

        public IngresarModel(IRopaServicio ropaServicio)
        {
            _ropaServicio = ropaServicio;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _ropaServicio.Agregar(RopaNuevo);
                return RedirectToPage("Galeria");
            }

            return Page();

        }
    }
}
