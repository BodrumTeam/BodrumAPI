using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class CommentManager : Repository<BodrumEntities
        , Comment>
    {
        public CommentManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public CommentManager() : this(new BodrumEntities())
        {
        }
    }
}