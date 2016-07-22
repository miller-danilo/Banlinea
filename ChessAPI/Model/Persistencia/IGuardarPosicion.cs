using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Persistencia
{
    public interface IGuardarPosicion
    {
        bool GuardarPosicion(Ficha ficha);
    }
}
