using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class CountryManager : Repository<BodrumEntities, Country>
    {
        public CountryManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public CountryManager() : this(new BodrumEntities())
        {
        }
    }
}