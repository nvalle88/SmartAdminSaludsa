using System;
using System.Reflection;
using log4net;
using SmartAdminSaludsa.Extensores;

namespace SistemaPedidos.Utilidades
{

    /// <summary>
    /// 
    /// </summary>
    public enum TypeError
    {
        Info,
        Warning,
        Error,
    }


    /// <summary>
    /// 
    /// </summary>
    public static class Log
    {
        #region Instancias

        /// <summary>
        /// Logger
        /// </summary>
        public static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        #endregion Instancias

        public static string ObtenerIdTransaccion() => Guid.NewGuid().ToString();


        public static void WriteLog(string id, TypeError typeError, object log=null,string Proceso="",string usuario="")
        {
            try
            {
                switch (typeError)
                {
                    case TypeError.Info:
                        Logger.Info($"{id}-{Proceso}-{usuario}-{log.Serializar()}");
                        break;
                    case TypeError.Warning:
                        Logger.Warn($"{id}-{Proceso}-{usuario}-{log.Serializar()}");
                        break;
                    case TypeError.Error:
                        Logger.Error($"{id}-{Proceso}-{usuario}-{log.Serializar()}");
                        break;
                }
            }
            catch
            {
            }
        }
    }

    
}