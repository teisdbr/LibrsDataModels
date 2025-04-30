using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;


namespace LibrsModels.Classes
{
    public class RelationshipsToProperty : LegacyLibrsValues
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