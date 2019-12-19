
namespace Seccion.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        StoreEntities dbContext;
        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = new StoreEntities());
        }

        /// <summary>
        /// Libera los recursos asignados para este contexto.
        /// </summary>
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
