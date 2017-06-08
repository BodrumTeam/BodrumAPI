using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class ItemManager : Repository<BodrumEntities, Item>
    {
        public ItemManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public ItemManager() : this(new BodrumEntities())
        {
        }
    }
}