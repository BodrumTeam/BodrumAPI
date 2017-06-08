using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class RoleManager : Repository<BodrumEntities, Role>
    {
        public RoleManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public RoleManager() : this(new BodrumEntities())
        {
        }
    }
}