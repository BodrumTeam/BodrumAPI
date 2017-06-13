using Entity.DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.BLL.Managers
{
    public class RegionManager : Repository<BodrumEntities, Region>
    {
        public RegionManager(BodrumEntities ctx) : base(ctx)
        {
        }
        public RegionManager() : this(new BodrumEntities())
        {
        }
    }
}