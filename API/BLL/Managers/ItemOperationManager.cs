using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class ItemOperationManager : Repository<BodrumEntities, Item_Operation>
    {
        public ItemOperationManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public ItemOperationManager() : this(new BodrumEntities())
        {
        }
    }
}