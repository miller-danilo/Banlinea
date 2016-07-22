using ChessAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessAPI.Models
{
    public class RespuestaChessAPI
    {
        public TipoFicha Nombre { get; set; }
        public string Mensaje { get; set; }
        public List<Posicion> MovimientosPosibles { get; set; }
        public Posicion PosicionActual { get; set; }
    }
}