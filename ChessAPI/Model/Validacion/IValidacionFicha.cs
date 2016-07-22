using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Validacion
{
    public interface IValidacionFicha
    {
        bool ValidarMovimiento(Posicion posicionActual, Posicion nuevaPosicion);
        List<Posicion> MovimientosPosibles(Posicion posicionActual);
    }
}
