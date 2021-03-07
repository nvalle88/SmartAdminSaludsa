namespace SmartAdmin.Seed.Models.DTO
{
    public class RespuestaGenerica
    {
        public string Estado { get; set; }
        public object Resultado { get; set; }
        public string Mensaje { get; set; }
    }

    public class RespuestaGenericaPaginada : RespuestaGenerica
    {
        public int TotalRegistros { get; set; }
    }

    public static class Respuesta
    {
        public static string OK => "OK";
        public static string Error => "Error";
    }
}
