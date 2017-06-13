using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class CityManager : Repository<BodrumEntities, City>
    {
        public CityManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public CityManager() : this(new BodrumEntities())
        {
        }
    }
}