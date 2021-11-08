using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.interfaces;
using Tourism.Data.Models;

namespace Tourism.Data.Repository
{
    public class RegionRepository : IAllRegions
    {
        private readonly AppDBContent appDBContent;

        public RegionRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Region> Regions => appDBContent.Region.Include(c => c.Category);

        public Region getObjectRegion(int regionID) => appDBContent.Region.FirstOrDefault(p => p.id == regionID);
    }
}
