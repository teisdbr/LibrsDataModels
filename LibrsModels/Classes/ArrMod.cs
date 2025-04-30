using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    //This one is a work in progress... Don't really know what goes in here. 
    public class ArrMod : LegacyLibrsValues
    {
        [JsonPropertyName("lrsNumber")]
        public string LRSNumber { get; set; }
        public ArrMod()
        {
            SegmentDescriptor = "63";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 101));
        }
    }
}