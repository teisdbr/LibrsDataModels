using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    //This one is a work in progress... Don't really know what goes in here. 
    public class PropMod : LegacyLibrsValues
    {
        [JsonPropertyName("lrsNumber")]
        public string LRSNumber { get; set; }
        
        public PropMod()
        {
            SegmentDescriptor = "32";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 92));
        }
    }
}