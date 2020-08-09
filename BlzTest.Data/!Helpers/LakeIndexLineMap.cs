using BlzTest.Data.Models;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlzTest.Data._Helpers
{
    public class LakeIndexLineMap: ClassMap<LakeIndexLine>
    {
        public LakeIndexLineMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.LakeName).Name("LakeName");
            Map(m => m.DnrNumber).Name("DnrNumber");
            Map(m => m.Tier).Name("Tier");
            Map(m => m.County).Name("County");
            Map(m => m.EcoRegion).Name("EcoRegion");
            Map(m => m.IsSentinel).Name("IsSentinel");

        }
    }
}
