using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAPI.Model.Persistencia
{
    class GuardarSQL : IGuardarPosicion
    {
        public bool GuardarPosicion(Ficha ficha)
        {
            try
            {
                using (DAL.AjedrezContextContainer db = new DAL.AjedrezContextContainer())
                {
                    DAL.TipoFichaDB tipoFichaDB = db.TipoFichaDBSet.Where(tf => tf.Id == (int)ficha.Nombre).FirstOrDefault();

                    db.FichaDBSet.Add(new DAL.FichaDB()
                    {
                        TipoFichaDB = tipoFichaDB,
                        X = ficha.PosicionActual.X,
                        Y = ficha.PosicionActual.Y
                    });

                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception EX)
            {
                return false;
            }
        }
    }
}
