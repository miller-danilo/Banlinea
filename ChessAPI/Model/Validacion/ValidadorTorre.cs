using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Validacion
{
    public class ValidadorTorre : IValidacionFicha
    {
        public List<Posicion> MovimientosPosibles(Posicion posicionActual)
        {
            List<Posicion> posiciones = new List<Posicion>();

            for (int columnas = 0; columnas < posicionActual.X; columnas++)
            {
                posiciones.Add(new Posicion(columnas, posicionActual.Y));
            }

            for (int columnas = posicionActual.X + 1; columnas <= Constantes.MAXIMA_POSICION; columnas++)
            {
                posiciones.Add(new Posicion(columnas, posicionActual.Y));
            }

            for (int filas = 0; filas < posicionActual.Y; filas++)
            {
                posiciones.Add(new Posicion(posicionActual.X, filas));
            }

            for (int filas = posicionActual.Y + 1; filas <= Constantes.MAXIMA_POSICION; filas++)
            {
                posiciones.Add(new Posicion(posicionActual.X, filas));
            }

            return posiciones;
        }

        public bool ValidarMovimiento(Posicion posicionActual, Posicion nuevaPosicion)
        {
            if (MovimientosPosibles(posicionActual).Where(p => p.X == nuevaPosicion.X && p.Y == nuevaPosicion.Y).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }
    }
}
