using Seccion.Data.Infrastructure;
using Seccion.Model.TblModels;

namespace Seccion.Data.Repositories
{
    public interface ITbEmployeeRepository : IRepository<TbEmployee>
    {

    }
    public class TbEmployeeRepository : RepositoryBase<TbEmployee>, ITbEmployeeRepository
    {
        public TbEmployeeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
