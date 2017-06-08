using System;
using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class UserMobileManager : Repository<BodrumEntities, UserMobile>
    {
        public UserMobileManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public UserMobileManager() : this(new BodrumEntities())
        {
        }
    }
}