using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Validacion
{
    public class FactoryValidacion
    {
        public static IValidacionFicha CrearValidador(TipoFicha nombre)
        {
            IValidacionFicha validador;
            switch(nombre)
            {
                case TipoFicha.ALFIL:
                    validador = new ValidadorAlfil();
                    break;
                case TipoFicha.TORRE:
                    validador = new ValidadorTorre();
                    break;
                default:
                    throw new NotImplementedException(string.Format("No se ha implementado la ficha {0}", nombre.ToString()));
            }

            return validador;
        }
    }
}
