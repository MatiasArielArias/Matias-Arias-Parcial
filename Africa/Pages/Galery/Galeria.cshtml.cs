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
    public class GaleriaModel : PageModel
    {
        [BindProperty]
        public List<Ropa> Ropas { get; set; }

        private IRopaServicio _ropaServicio;

        public GaleriaModel(IRopaServicio ropaServicio)
        {
            _ropaServicio = ropaServicio;
        }

        public void OnGet(string orden)
        {
            Ropas = _ropaServicio.MostrarTodos().ToList();
            if (orden == "PorNombre")
            {
                Ropas = Ropas.OrderBy(x => x.NombrePrenda).ToList();
            }
            else if (orden == "PorPrenda")
            {
                Ropas = Ropas.OrderBy(x => x.Prenda).ToList();
            }
            else if (orden == "PorCantidad")
            {
                Ropas = Ropas.OrderBy(x => x.CantidadStock).ToList();
            }
            else
            {
                Ropas = Ropas.OrderBy(x => x.ID).ToList();
            }

        }
        public IActionResult OnPost()
        {
            return RedirectToPage("Ingresar");
        }

        public void OnGetEliminar(int IDEliminar)
        {
            var ropaBorrar = _ropaServicio.MostrarTodos().Where(x => x.ID == IDEliminar).First();
            _ropaServicio.Eliminar(ropaBorrar);
            Ropas = _ropaServicio.MostrarTodos().ToList();

        }
        public void OnPostBuscar(string PrendaBuscar)
        {
            if (PrendaBuscar == null)
            {
                Ropas = _ropaServicio.MostrarTodos().ToList();
            }
            else
            {
                Ropas = _ropaServicio.MostrarTodos().Where(x => x.Prenda == PrendaBuscar).ToList();
            }
        }
    }
}