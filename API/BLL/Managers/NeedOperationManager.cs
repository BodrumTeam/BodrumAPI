using System;
using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class NeedOperationManager : Repository<BodrumEntities, Needs_OperationType>
    {
        public NeedOperationManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public NeedOperationManager() : this(new BodrumEntities())
        {
        }
    }
}