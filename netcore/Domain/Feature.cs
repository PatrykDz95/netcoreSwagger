using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netCore.Models;
namespace netCore.Models
{
    public class Feature
    {

        public int Id { get; set; }
        public int ChangeCode { get; set; }
        public string Description { get; set; }
        public string FeatureID { get; set; }
        public int LogicalValue { get; set; }
        public int NumericValue { get; set; }
        public int RangeLowerValue { get; set; }
        public int RangeUpperValue { get; set; }
        public char Type { get; set; }
        public string UnitDescription { get; set; }
        public string UnitID { get; set; }
        public char UnitShortNotation { get; set; }
        public int ValueDescription { get; set; }
        public int ValueID { get; set; }

    }
}
