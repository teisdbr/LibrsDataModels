using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Error
    {
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }
        
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }
        
        [JsonPropertyName("contents")]
        public string Contents { get; set; }
        
        [JsonPropertyName("dataElem")]
        public string DataElem { get; set; }
        
        [JsonPropertyName("incidentNumber")]
        public string IncidentNumber { get; set; }
        
        [JsonPropertyName("segmentNumber")]
        public string SegmentNumber { get; set; }
    }
}