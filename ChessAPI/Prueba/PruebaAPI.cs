using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using ChessAPI.Models;
using System.Web.Http;

namespace Prueba
{
    [TestClass]
    public class PruebaAPI
    {
        [TestMethod]
        public void MovimientoCorrecto()
        {
            var controller = new ChessAPI.Controllers.ChessAPIController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            Movimiento movimiento = new Movimiento()
            {
                Nombre = ChessAPI.Model.TipoFicha.TORRE,
                PosicionActual = new ChessAPI.Model.Posicion(0, 0),
                NuevaPosicion = new ChessAPI.Model.Posicion(0, 1)
            };
            Newtonsoft.Json.Converters.
            var response = controller.Mover(movimiento);

            RespuestaChessAPI respuesta;
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.TryGetContentValue<RespuestaChessAPI>(out respuesta));
            Assert.AreEqual(respuesta.PosicionActual.X, 0);
            Assert.AreEqual(respuesta.PosicionActual.Y, 1);            
        }

        [TestMethod]
        public void MovimientoNoPermitido()
        {
            var controller = new ChessAPI.Controllers.ChessAPIController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            Movimiento movimiento = new Movimiento()
            {
                Nombre = ChessAPI.Model.TipoFicha.TORRE,
                PosicionActual = new ChessAPI.Model.Posicion(0, 0),
                NuevaPosicion = new ChessAPI.Model.Posicion(1, 1)
            };
            var response = controller.Mover(movimiento);

            RespuestaChessAPI respuesta;
            Assert.AreEqual(System.Net.HttpStatusCode.Forbidden, response.StatusCode);
            Assert.IsTrue(response.TryGetContentValue<RespuestaChessAPI>(out respuesta));            
            Assert.AreEqual(respuesta.PosicionActual.X, 0);
            Assert.AreEqual(respuesta.PosicionActual.Y, 0);
            Assert.IsTrue(respuesta.MovimientosPosibles.Count > 0);
        }
    }
}
