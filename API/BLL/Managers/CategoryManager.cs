using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class CategoryManager : Repository<BodrumEntities, Category>
    {
        public CategoryManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public CategoryManager() : this(new BodrumEntities())
        {
        }
    }
}