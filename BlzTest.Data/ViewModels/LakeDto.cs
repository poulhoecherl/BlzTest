using System;
using System.Collections.Generic;

namespace BlzTest.Data.ViewModels
{
    public class LakeDto
    {
        public string Id { get; set; }

        public string LakeName { get; set; }

        public string DnrNumber { get; set; }

        public string Tier { get; set; }

        public string County { get; set; }
        
        public string EcoRegion { get; set; }

        public string IsSentinel { get; set; }

        public List<FishDto> FishList { get; set; }

    }
}