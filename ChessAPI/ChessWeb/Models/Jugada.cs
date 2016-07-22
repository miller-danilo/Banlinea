using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChessWeb.Models
{
    public class Jugada
    {
        [Display(Name = "X")]
        [Required]
        public int X { get; set; }
        [Display(Name = "Y")]
        [Required]
        public int Y { get; set; }

        [Display(Name = "Nueva X")]
        [Required]
        public int NuevaX { get; set; }
        [Display(Name = "Nueva Y")]
        [Required]
        public int NuevaY { get; set; }

        [Display(Name = "Ficha")]
        [Required]
        public int TipoFicha { get; set; }

        public IEnumerable<SelectListItem> TiposFichas { get; set; }
    }
}