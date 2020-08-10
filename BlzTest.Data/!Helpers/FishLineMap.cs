using BlzTest.Data.Models;
using CsvHelper.Configuration;

namespace BlzTest.Data._Helpers
{
    public class FishLineMap: ClassMap<FishLine>
    {
        public FishLineMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.FishList).Name("FishList");
        }
    }
}
