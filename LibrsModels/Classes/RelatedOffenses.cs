using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class RelatedOffenses : LegacyLibrsValues
        {
        
        [JsonPropertyName("offenseSeqNum")]
        public string OffenseSeqNum { get; set; }
        
        [JsonPropertyName("attemptedCompleted")]
        public string AttemptedCompleted { get; set; }
        
        [JsonPropertyName("offConnecttoVic")]
        public string OffConnecttoVic { get; set; }
        
        [JsonPropertyName("locationType")]
        public string LocationType { get; set; }
        
        [JsonPropertyName("premises")]
        public string Premises { get; set; }
        
        [JsonPropertyName("methodOfEntry")]
        public string MethodOfEntry { get; set; }
        
        [JsonPropertyName("criminalActivity1")]
        public string CriminalActivity1 { get; set; }
        
        [JsonPropertyName("criminalActivity2")]
        public string CriminalActivity2 { get; set; }
        
        [JsonPropertyName("criminalActivity3")]
        public string CriminalActivity3 { get; set; }
        
        [JsonPropertyName("weaponForce1")]
        public string WeaponForce1 { get; set; }
        
        [JsonPropertyName("weaponForce2")]
        public string WeaponForce2 { get; set; }
        
        [JsonPropertyName("weaponForce3")]
        public string WeaponForce3 { get; set; }
        
        [JsonPropertyName("agencyAssignedNibrs")]
        public string AgencyAssignedNibrs { get; set; }
        
        [JsonIgnore]
        public List<RelationshipsToProperty> RelationshipsToProperties { get; set; }

        [JsonIgnore]
        public List<RelatedProperty> RelatedProperties { get; set; }

        [JsonIgnore]
        public int PropertyLossTypeFlags { get; set; }

        [JsonIgnore]
        public List<ValidateLars> ValidateLars { get; set; }

        [JsonIgnore]
        public List<FbiValidate> FbiValidates { get; set; }
        
        [JsonPropertyName("lrsNumber")]
        public string LrsNumber { get; set; }

        [JsonIgnore]
        public bool OfficerDidAssignNibrs { get; set; }
        
        [JsonPropertyName("inchoate")]
        public string Inchoate { get; set; }
        
        [JsonPropertyName("offenseGroup")]
        public string OffenseGroup { get; set; }
    }
}