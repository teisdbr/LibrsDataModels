using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class VicInjury: LegacyLibrsValues, IPaddingFixer
    {

        [JsonPropertyName("victimSeqNum")] public string VictimSeqNum { get; set; } = "   ";

        [JsonPropertyName("injuryType")] public string InjuryType { get; set; } = " ";
        
        public VicInjury()
        {
            SegmentDescriptor = "51";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }

        public void FixPaddings()
        {
            VictimSeqNum = VictimSeqNum.PadL(3, '0');;
            InjuryType = InjuryType.PadR(1);
        }
    }
}