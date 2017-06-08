using System;
using Entity.DAL;
using Repository;

namespace API.BLL.Managers
{
    public class OperationManager : Repository<BodrumEntities, Operation>
    {
        public OperationManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public OperationManager() : this(new BodrumEntities())
        {
        }
    }
}