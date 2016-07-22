using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Persistencia
{
    public class FactoryPersistencia
    {
        public static IGuardarPosicion CrearPersistencia(TipoPersistencia tipoPersistencia)
        {
            switch (tipoPersistencia)
            {
                case TipoPersistencia.SQLSERVER:
                    return new GuardarSQL();

                case TipoPersistencia.XML:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
