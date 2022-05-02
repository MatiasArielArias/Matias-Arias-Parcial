using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Africa.Modelo
{
    public class Ropa
    {
        [Required(ErrorMessage = "Ingrese un ID")]
        [Range(1, 1000, ErrorMessage = "Ingrese un numero entre 1 y 1000")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese una prenda")]
        [MaxLength(20)]
        public string Prenda { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre a la prenda")]
        [MaxLength(50)]
        public string NombrePrenda { get; set; }
        public int CantidadStock { get; set; }
        public bool Stock { get; set; }

    }
}