
namespace Seccion.Data.Infrastructure
{
    /// <summary>
    /// responsable de enviar un comando Commit a la base de datos
    /// </summary>
    public interface IUnitOfWork
    {
        void Commit();
    }
}
