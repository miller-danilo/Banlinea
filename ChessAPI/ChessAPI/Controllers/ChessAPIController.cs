using ChessAPI.Model;
using ChessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChessAPI.Controllers
{
    [RoutePrefix("api/Jugada")]
    public class ChessAPIController : ApiController
    {
        [Route("Mover")]
        [ResponseType(typeof(RespuestaChessAPI))]
        [HttpPost]
        public HttpResponseMessage Mover(Movimiento movimiento)
        {
            RespuestaChessAPI respuesta = new RespuestaChessAPI();
            HttpResponseMessage mensajeHttp;
            try
            {
                Ficha ficha = new Ficha()
                {
                    Nombre = movimiento.Nombre,
                    PosicionActual = movimiento.PosicionActual
                };

                respuesta.Nombre = movimiento.Nombre;
                respuesta.PosicionActual = movimiento.PosicionActual;

                if (ficha.Validar(movimiento.NuevaPosicion))
                {
                    respuesta.PosicionActual = ficha.PosicionActual;
                    mensajeHttp = this.Request.CreateResponse(HttpStatusCode.OK, respuesta);
                }
                else
                {
                    respuesta.Mensaje = "El movimiento no es válido";
                    respuesta.MovimientosPosibles = ficha.MovimientosPosibles;
                    mensajeHttp = this.Request.CreateResponse(HttpStatusCode.Forbidden, respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
                mensajeHttp = this.Request.CreateResponse(HttpStatusCode.InternalServerError, respuesta);
            }

            return mensajeHttp;
        }
    }
}
