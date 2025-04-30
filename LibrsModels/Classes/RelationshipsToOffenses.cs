using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class RelationshipsToOffenses : LegacyLibrsValues
        {
        
        [JsonPropertyName("propertySequenceNumber")]
        public string PropertySequenceNumber { get; set; }
        
        [JsonPropertyName("offenseSequenceNumber")]
        public string OffenseSequenceNumber { get; set; }


        [JsonIgnore]
        public List<AssociatedProperty> AssociatedProperties { get; set; }

        [JsonIgnore]
        public List<AssociatedOffenses> AssociatedOffenses { get; set; }

        [JsonIgnore]
        public bool IsDuplicate { get; set; }
    }
}