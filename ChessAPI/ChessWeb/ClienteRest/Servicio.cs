using ChessWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace ChessWeb.ClienteRest
{
    public class Servicio
    {
        string url = ConfigurationManager.AppSettings["urlServicio"];
        //public Jugada Mover()
        //{
        //    string method = @"api/Jugada/Mover";

        //    using (WebClient webClient = new WebClient())
        //    {
        //        webClient.BaseAddress = url;
        //        webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");

        //        return JsonConvert.DeserializeObject<LoginResult>(
        //            webClient.UploadString(uri + method, JsonConvert.SerializeObject(usuario))
        //        );
        //    }
        //}
    }
}