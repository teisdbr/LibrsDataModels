using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Warning
    {
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }
        
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }
        
        [JsonPropertyName("contents")]
        public string Contents { get; set; }
        
        [JsonPropertyName("dataElem")]
        public string DataElem { get; set; }

    }
}