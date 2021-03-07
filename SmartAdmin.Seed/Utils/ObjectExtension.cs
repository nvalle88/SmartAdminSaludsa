using Newtonsoft.Json;

namespace SmartAdminSaludsa.Extensores
{
    public static class ObjectExtension
    {
        public static object Serializar(this object str)
        {
			try
			{
				return str == null ? string.Empty : JsonConvert.SerializeObject(str);
			}
			catch (System.Exception)
			{

				return string.Empty;
			}
        }
    }
}