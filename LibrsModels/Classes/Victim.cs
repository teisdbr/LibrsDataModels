using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Victim: LegacyLibrsValues, IPaddingFixer
    {
        [JsonIgnore]
        public int GetAllPossibleAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09aAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09bAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09cAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetProvidedAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public bool AreAllDataElement31ProvidedChoicesValid { get; set; }
        
        [JsonIgnore]
        public List<object> GetInvalidDataElement31Choices { get; set; }

        

        [JsonPropertyName("victimSeqNum")] public int? VictimSeqNum { get; set; }

        [JsonPropertyName("victimType")] public string VictimType { get; set; } = " ";

        [JsonPropertyName("age")] public string Age { get; set; }
        [JsonPropertyName("estimatedAge")] public bool EstimatedAge { get; set; } = false;

        [JsonPropertyName("dob")] public DateTime? DOB { get; set; }

        [JsonPropertyName("sex")] public string Sex { get; set; } = " ";

        [JsonPropertyName("gender")] public string Gender { get; set; } = "   ";
        
        [JsonPropertyName("race")] public string Race { get; set; } = " ";

        [JsonPropertyName("ethnicity")] public string Ethnicity { get; set; } = " ";

        [JsonPropertyName("residentStatus")] public string ResidentStatus { get; set; } = " ";

        [JsonPropertyName("aggravatedAssault")] public List<int> AggravatedAssault { get; set; } = new List<int>();

        [JsonPropertyName("additionalHomicide")] public string AdditionalHomicide { get; set; } = " ";

        [JsonPropertyName("precipitatingOffense")] public string PrecipitatingOffense { get; set; } = "   ";

        [JsonPropertyName("officerActivity")] public int? OfficerActivity { get; set; }

        [JsonPropertyName("officerAssignmentType")] public string OfficerAssignmentType { get; set; } = " ";

        [JsonPropertyName("officerOri")] public string OfficerOri { get; set; } = "         ";

        [JsonPropertyName("injuryType")] public string InjuryType { get; set; } = " ";
        
        [JsonPropertyName("relatedOffenders")] public List<VicOff> RelatedOffenders { get; set; }
        
        public Victim()
        {
            SegmentDescriptor = "50";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 6));
            Padding = string.Concat(Enumerable.Repeat(" ", 81));
        }

        public void FixPaddings()
        {
            //VictimSeqNum = VictimSeqNum.PadL(3, '0');;
            VictimType = VictimType.PadR(1);
            //Age = PadVictimAge(Age);
            Ethnicity = Ethnicity.PadR(1);
            Gender = Gender.PadR(3);
            ResidentStatus = ResidentStatus.PadR(1);
            AdditionalHomicide = AdditionalHomicide.PadR(1);
            //AggravatedAssault.ForEach(val => val.PadR(2));
            //OfficerActivityCircumstance = OfficerActivityCircumstance.PadL(2, '0');
            OfficerAssignmentType = OfficerAssignmentType.PadR(1);
            PrecipitatingOffense = PrecipitatingOffense.PadR(3);
            OfficerOri = OfficerOri.PadL(9);
        }

        public string PadVictimAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age)) return "".PadR(3);
            // If estimated, pad 3 characters
            if (age.Contains('E'))
            {
                return age.PadL(3, '0');
            } 
            else if (int.TryParse(age, out var parsedAge))
            {
                return parsedAge.ToString().PadL(2, '0') + ' ';
            }

            // If all else fails, pad to 3 spaces. This helps against 'NB ' for instance.
            return age.PadR(3);
        }
    }
}