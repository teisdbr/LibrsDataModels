using System.Text.Json;
using System.Text.Json.Serialization;
namespace LibrsModels.Classes
{
    public class LegacyLibrsValues
    {
        [JsonPropertyName("entireLineSegment")]
        public string EntireLineSegment { get; set; }

        [JsonPropertyName("segmentDescriptor")]
        public string SegmentDescriptor { get; set; }

        [JsonPropertyName("actionType")]
        public string ActionType { get; set; }

        [JsonPropertyName("oriNumber")]
        public string ORINumber { get; set; }

        [JsonPropertyName("incidentNumber")]
        public string IncidentNumber { get; set; }

        [JsonPropertyName("expansionBuffer")]
        public string ExpansionBuffer { get; set; }

        [JsonPropertyName("segmentEnd")]
        public string SegmentEnd = "ZZ";

        [JsonPropertyName("padding")]
        public string Padding { get; set; }
    }
}