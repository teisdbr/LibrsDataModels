using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Offender : LegacyLibrsValues, IPaddingFixer
    {

        [JsonPropertyName("offenderSeqNum")] public int? OffenderSeqNum { get; set; }

        [JsonPropertyName("age")] public string Age { get; set; }
        [JsonPropertyName("estimatedAge")] public bool EstimatedAge { get; set; } = false;

        [JsonPropertyName("dob")] public DateTime? Dob { get; set; }

        [JsonPropertyName("sex")] public string Sex { get; set; } = " ";

        [JsonPropertyName("race")] public string Race { get; set; } = " ";
        
        [JsonPropertyName("gender")] public string Gender { get; set; } = "   ";
        [JsonPropertyName("biasMotivation")] public int? BiasMotivation { get; set; }

        [JsonPropertyName("ethnicity")] public string Ethnicity { get; set; } = " ";
        
        [JsonPropertyName("usingGaming")] public List<string> UsingGaming { get; set; }
        public Offender()
        {
            SegmentDescriptor = "40";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 19));
            Padding = string.Concat(Enumerable.Repeat(" ", 86));
        }

        public void FixPaddings()
        {
            //OffenderSeqNum = OffenderSeqNum.PadL(3, '0');;
            //Age = PadOffenderAge(Age);
            Sex = Sex.PadR(1);
            Gender = Gender.PadR(3);
            Race = Race.PadR(1);
            //BiasMotivation = BiasMotivation.PadL(2);
            Ethnicity = Ethnicity.PadR(1);
        }

        public string PadOffenderAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age)) return "".PadR(3);
            if (age.Contains('E'))
            {
                return age.PadL(3, '0');
            }

            // Leave the third space with whitespace, but pad with 0, the leftmost 2 chars
            return age.PadL(2, '0') + ' ';

        }
    }
}