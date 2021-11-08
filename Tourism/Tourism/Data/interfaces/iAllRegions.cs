using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Data.Models;

namespace Tourism.Data.interfaces
{
    public interface IAllRegions
    {
        IEnumerable<Region> Regions { get; }
        Region getObjectRegion(int regionID);
    }
}
