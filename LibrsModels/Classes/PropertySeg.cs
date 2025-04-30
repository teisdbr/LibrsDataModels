using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class PropertySeg: LegacyLibrsValues, IPaddingFixer
    {
        [JsonPropertyName("numOfStolenVehicles")] public int? NumOfStolenVehicles { get; set; }

        [JsonPropertyName("numOfRecoveredVehicles")]
        public int? NumOfRecoveredVehicles { get; set; }
        
        public PropertySeg()
        {
            SegmentDescriptor = "30";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }

        public void FixPaddings()
        {
            //NumOfStolenVehicles = NumOfStolenVehicles == "0" ? "".PadR(2) : NumOfStolenVehicles.PadL(2, '0');
            //NumOfRecoveredVehicles = NumOfRecoveredVehicles == "0" ? "".PadR(2) : NumOfRecoveredVehicles.PadL(2, '0');
        }
    }
}