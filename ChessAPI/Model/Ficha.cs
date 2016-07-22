using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessAPI.Model.Validacion;
using ChessAPI.Model.Persistencia;
using System.Configuration;

namespace ChessAPI.Model
{
    public class Ficha
    {
        public TipoFicha Nombre { get; set; }
        public Posicion PosicionActual { get; set; }
        public List<Posicion> MovimientosPosibles { get; set; }

        private IValidacionFicha Validador { get; set; }
        private IGuardarPosicion ManejadorPersistencia { get; set; }

        public bool Validar(Posicion movimiento)
        {
            Validador = FactoryValidacion.CrearValidador(Nombre);
            ManejadorPersistencia = FactoryPersistencia.CrearPersistencia(TipoPersistencia.SQLSERVER); 
            bool resultado = Validador.ValidarMovimiento(PosicionActual, movimiento);

            if (!resultado)
            {
                MovimientosPosibles = Validador.MovimientosPosibles(PosicionActual);
            }
            else
            {
                PosicionActual = movimiento;
                ManejadorPersistencia.GuardarPosicion(this);
            }

            return resultado;
        }
    }
}
