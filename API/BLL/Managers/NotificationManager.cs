using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class NotificationManager : Repository<BodrumEntities, Notification>
    {
        public NotificationManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public NotificationManager() : this(new BodrumEntities())
        {
        }
    }
}