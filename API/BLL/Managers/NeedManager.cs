using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class NeedManager : Repository<BodrumEntities, Need>
    {
        public NeedManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public NeedManager() : this(new BodrumEntities())
        {
        }
    }
}