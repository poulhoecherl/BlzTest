using BlzTest.Data.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BlzTest.Data._Helpers
{
    public class Csv
    {
        
        public static List<LakeIndexLine> ImportLakeIndexLine(string filePath)
        {//C:\Users\pheck\Source\Repos\BlzTest\BlzTest.Data\DataFiles\LakeIndex.csv
            try
            {
                List<LakeIndexLine> reVal = new List<LakeIndexLine>();

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.RegisterClassMap<LakeIndexLineMap>();
                    var records = csv.GetRecords<LakeIndexLine>();

                    if(records != null)
                    {
                        foreach(var record in records)
                        {
                            reVal.Add(new LakeIndexLine()
                            {
                                Id = record.Id,
                                LakeName = record.LakeName,
                                County = record.County,
                                DnrNumber = record.DnrNumber,
                                EcoRegion = record.EcoRegion,
                                IsSentinel = record.IsSentinel,
                                Tier = record.Tier
                            });
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
