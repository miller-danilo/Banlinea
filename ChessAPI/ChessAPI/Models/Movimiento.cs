using ChessAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChessAPI.Models
{
    [DataContract]
    public class Movimiento
    {
        [DataMember]
        public TipoFicha Nombre { get; set; }
        [DataMember]
        public Posicion PosicionActual { get; set; }
        [DataMember]
        public Posicion NuevaPosicion { get; set; }
    }
}