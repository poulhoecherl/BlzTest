using BlzTest.Data.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BlzTest.Data._Helpers
{
    public class Csv
    {
        
        public static List<Lake> LoadLakeData(string filePath)
        {//C:\Users\pheck\Source\Repos\BlzTest\BlzTest.Data\DataFiles\LakeIndex.csv
            try
            {
                List<Lake> reVal = new List<Lake>();

                var fishPath = Path.Combine(Path.GetDirectoryName(filePath), "fishList.csv");
                using (var fishReader = new StreamReader(filePath))
                using (var fishCsv = new CsvReader(fishReader, CultureInfo.InvariantCulture)){

                    fishCsv.Configuration.RegisterClassMap<FishLineMap>();
                    
                    var fishes = fishCsv.GetRecords<FishLine>();

                    using (var lakeReader = new StreamReader(filePath))

                    using (var csv = new CsvReader(lakeReader, CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.RegisterClassMap<LakeIndexLineMap>();
                        var lakes = csv.GetRecords<Lake>();

                        if(lakes != null)
                        {
                            foreach(var record in lakes)
                            {
                                var fishList = (from a in fishes where a.Id == record.Id select a).SingleOrDefault();
                                
                                reVal.Add(new Lake()
                                {
                                    Id = record.Id,
                                    LakeName = record.LakeName,
                                    County = record.County,
                                    DnrNumber = record.DnrNumber,
                                    EcoRegion = record.EcoRegion,
                                    IsSentinel = record.IsSentinel,
                                    Tier = record.Tier,
                                    FishList = fishList.ToString()
                                });
                            }
                        }
                    }
                }
                return reVal;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return null;
            
        }

    }
}
