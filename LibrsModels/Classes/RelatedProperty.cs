using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class RelatedProperty: LegacyLibrsValues
    {
        
        [JsonPropertyName("propertyLossType")]
        public string PropertyLossType { get; set; }
        
        [JsonPropertyName("propertyDescription")]
        public string PropertyDescription { get; set; }
        
        [JsonPropertyName("propertyValue")]
        public string PropertyValue { get; set; }
        
        [JsonPropertyName("dateRecovered")]
        public string DateRecovered { get; set; }
        
        [JsonPropertyName("suspectedDrugType")]
        public string SuspectedDrugType { get; set; }
        
        [JsonPropertyName("estimatedDrugQty")]
        public string EstimatedDrugQty { get; set; }
        
        [JsonPropertyName("typeDrugMeas")]
        public string TypeDrugMeas { get; set; }
        
        [JsonPropertyName("tyNum")]
        public object ty_num { get; set; }
        
        [JsonPropertyName("lars")]
        public object la_rs { get; set; }
        
        [JsonPropertyName("nibr")]
        public object nibr { get; set; }
        
        [JsonPropertyName("nValProp")]
        public int n_val_prop { get; set; }

        [JsonIgnore]
        public List<RelationshipsToOffenses> RelationshipsToOffenses { get; set; }

        [JsonIgnore]
        
        [JsonPropertyName("relatedOffenses")]
        public List<RelatedOffenses> RelatedOffenses { get; set; } 
    }
}