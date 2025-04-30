using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class FbiValidate
    {
        
        [JsonPropertyName("mandatory")]
        public string Mandatory { get; set; }
        
        [JsonPropertyName("dataElement")]
        public string DataElement { get; set; }
        
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
        
        [JsonPropertyName("subgroup")]
        public string Subgroup { get; set; }
        
        [JsonPropertyName("crimeAgainst")]
        public string CrimeAgainst { get; set; }
        
        [JsonPropertyName("expirationDate")]
        public string ExpirationDate { get; set; }
    }
}