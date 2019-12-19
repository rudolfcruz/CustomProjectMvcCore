using System;

namespace Seccion.Data.Infrastructure
{
    /// <summary>
    /// Así que creamos una interfaz de fábrica responsable de inicializar las instancias de esta clase
    /// </summary>
    public interface IDbFactory: IDisposable
    {
        StoreEntities Init();
    }
}
