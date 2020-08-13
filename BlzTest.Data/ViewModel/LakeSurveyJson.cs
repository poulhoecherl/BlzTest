using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlzTest.Data.Models
{
    public class AccessesItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string lakeAccessComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ownerTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string accessTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string publicUseAuthCode { get; set; }
    }

    public class FishCatchSummariesItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string quartileCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string quartileWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string averageWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CPUE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalCatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gearCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string species { get; set; }
    }

    public class WTS
    {

        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class YEB
    {

        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class BLC
    {

        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class PMK
    {

        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
    }

    public class YEP
    {

        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
    }

    public class NOP
    {

        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
    }

    public class BLG
    {

        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class RKB
    {

        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class LMB
    {

        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
    }

    public class WAE
    {

        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
    }

    public class BRB
    {

        /// <summary>
        /// 
        /// </summary>
        public int maximum_length { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<int>> fishCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minimum_length { get; set; }
    }

    public class Lengths
    {

        /// <summary>
        /// 
        /// </summary>
        public WTS WTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public YEB YEB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BLC BLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PMK PMK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public YEP YEP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NOP NOP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BLG BLG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RKB RKB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LMB LMB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WAE WAE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BRB BRB { get; set; }
    }

    public class SurveysItem
    {

        /// <summary>
        /// 
        /// </summary>
        public List<string> headerInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string surveyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FishCatchSummariesItem> fishCatchSummaries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string surveyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string narrative { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string surveySubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string surveyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lengths lengths { get; set; }
    }

    public class Result
    {

        /// <summary>
        /// 
        /// </summary>
        public int meanDepthFeet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AccessesItem> accesses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DOWNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double areaAcres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> sampledPlants { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int littoralAcres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double shoreLengthMiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string officeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SurveysItem> surveys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maxDepthFeet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string averageWaterClarity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> waterClarity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lakeName { get; set; }
    }

    public class Root
    {

        /// <summary>
        /// 
        /// </summary>
        public int timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
    }


}
