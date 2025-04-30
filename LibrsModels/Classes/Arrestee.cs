using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Arrestee: LegacyLibrsValues, IPaddingFixer
    {

        [JsonPropertyName("arrestSeqNum")] public int? ArrestSeqNum { get; set; }

        [JsonPropertyName("arrestNumber")] public string ArrestNumber { get; set; } = "            ";

        [JsonPropertyName("arrTransactionNumber")] public string ArrTransactionNumber { get; set; } = "               ";

        [JsonPropertyName("arresteeName")] public string ArresteeName { get; set; } = "                    ";

        [JsonPropertyName("arrestDate")] public DateTime? ArrestDate { get; set; }

        [JsonPropertyName("arrestType")] public string ArrestType { get; set; } = " ";

        [JsonPropertyName("multipleArresteeIndicator")]
        public string MultipleArresteeIndicator { get; set; } = "N";

        [JsonPropertyName("age")] public string Age { get; set; }
        [JsonPropertyName("estimatedAge")] public bool? EstimatedAge { get; set; }

        [JsonPropertyName("dob")] public DateTime? DOB { get; set; }

        [JsonPropertyName("sex")] public string Sex { get; set; } = " ";
        [JsonPropertyName("gender")] public string Gender { get; set; } = "   ";
        
        [JsonPropertyName("race")] public string Race { get; set; } = " ";

        [JsonPropertyName("ethnicity")] public string Ethnicity { get; set; } = " ";

        [JsonPropertyName("residentStatus")] public string ResidentStatus { get; set; } = " ";

        [JsonPropertyName("dispositionUnder18")] public string DispositionUnder18 { get; set; } = " ";

        [JsonPropertyName("clearanceIndicator")] public string ClearanceIndicator { get; set; } = " ";

        [JsonPropertyName("arrestArmed")] public List<Weapon> ArrestArmed { get; set; } = new List<Weapon>();

        [JsonPropertyName("arrestStatute")] public List<ArrStatute> ArrestStatute { get; set; } = new List<ArrStatute>();

        public Arrestee()
        {
            SegmentDescriptor = "60";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 17));
            Padding = string.Concat(Enumerable.Repeat(" ", 30));
        }

        public void FixPaddings()
        {
            //ArrestSeqNum = ArrestSeqNum.PadL(3, '0');;
            ArrestNumber = ArrestNumber.PadL(12);
            ArrTransactionNumber = ArrTransactionNumber.PadL(15);
            ArresteeName = ArresteeName.PadR(20);
            ArrestType = ArrestType.PadR(1);
            MultipleArresteeIndicator = MultipleArresteeIndicator.PadR(1);
            //Age = PadArresteeAge(Age);
            Sex = Sex.PadR(1);
            Gender = Gender.PadR(3);
            Race = Race.PadR(1);
            Ethnicity = Ethnicity.PadR(1);
            ResidentStatus = ResidentStatus.PadR(1);
            DispositionUnder18 = DispositionUnder18.PadR(1);
            ClearanceIndicator = ClearanceIndicator.PadR(1);
        }
        public string PadArresteeAge(string age)
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