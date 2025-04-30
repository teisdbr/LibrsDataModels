using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class VicOff : LegacyLibrsValues, IPaddingFixer
    {

        [JsonIgnore] public string VictimSeqNum { get; set; }

        [JsonPropertyName("offenderNumber")]
        public string OffenderNumberRelated { get; set; } = "   ";

        [JsonPropertyName("relationship")]
        public string VictimOffenderRelation { get; set; } = "  ";
        
        public VicOff()
        {
            SegmentDescriptor = "52";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }

        public void FixPaddings()
        {
            //VictimSeqNum = VictimSeqNum.PadL(3, '0');;
            OffenderNumberRelated = OffenderNumberRelated.PadL(3, '0');;
            VictimOffenderRelation = VictimOffenderRelation.PadR(2);
        }
    }
}