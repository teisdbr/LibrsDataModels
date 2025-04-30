using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class PropertyOffense : LegacyLibrsValues, IPaddingFixer
    {

        [JsonPropertyName("propertySequenceNumber")]
        public int? PropertySequenceNumber { get; set; }

        [JsonPropertyName("offenseSequenceNumber")]
        public int? OffenseSequenceNumber { get; set; }

        [JsonIgnore]
        public List<AssociatedProperty> AssociatedProperties { get; set; }

        [JsonIgnore]
        public List<AssociatedOffenses> AssociatedOffenses { get; set; }

        [JsonIgnore]
        public bool IsDuplicate { get; set; } = false;
        
        public PropertyOffense()
        {
            SegmentDescriptor = "33";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 98));
        }

        public void FixPaddings()
        {
            //PropertySequenceNumber = PropertySequenceNumber.PadL(3, '0');;
            //OffenseSequenceNumber = OffenseSequenceNumber.PadL(3, '0');;
        }
    }
}