using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model
{
    [DataContract]
    public class Posicion
    {
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }

        public Posicion(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
