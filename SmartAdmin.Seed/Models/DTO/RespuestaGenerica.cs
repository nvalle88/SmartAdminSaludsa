using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAdmin.Seed.Models.DTO
{
    public class RespuestaGenerica
    {
        public string Estado { get; set; }
        public object Resultado { get; set; }
        public string Mensaje { get; set; }
    }

    public static class Respuesta
    {
        public static string OK => "OK";
        public static string Error => "Error";
    }
}
