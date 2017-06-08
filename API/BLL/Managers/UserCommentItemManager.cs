using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class UserCommentItemManager : Repository<BodrumEntities, UserCommentOnItem>
    {
        public UserCommentItemManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public UserCommentItemManager() : this(new BodrumEntities())
        {
        }
    }
}