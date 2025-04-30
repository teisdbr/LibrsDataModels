using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Offense : LegacyLibrsValues, IPaddingFixer
    {
        [JsonPropertyName("offenseSeqNum")] public int? OffenseSeqNum { get; set; }

        [JsonPropertyName("isCompleted")] public bool IsCompleted { get; set; }

        [JsonPropertyName("offConnectToVic")] public int? OffConnectToVic { get; set; }

        [JsonPropertyName("locationType")] public int? LocationType { get; set; }

        [JsonPropertyName("premises")] public int? Premises { get; set; }

        [JsonPropertyName("methodOfEntry")] public string MethodOfEntry { get; set; } = " ";

        [JsonPropertyName("criminalActivity")] public List<string> CriminalActivity { get; set; } = new List<string>();

        [JsonPropertyName("weapons")] public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        [JsonPropertyName("cargoTheft")] public bool? CargoTheft { get; set; }

        [JsonPropertyName("agencyAssignedNibrs")] public string AgencyAssignedNibrs { get; set; } = "   ";

        [JsonIgnore]
        public List<RelationshipsToProperty> RelationshipsToProperties { get; set; }

        [JsonIgnore]
        public List<RelatedProperty> RelatedProperties { get; set; }
        
        [JsonPropertyName("propertyLossTypeFlags")]
        public int? PropertyLossTypeFlags { get; set; }
        
        [JsonIgnore]
        public List<ValidateLars> ValidateLars { get; set; }

        [JsonIgnore]
        public List<FbiValidate> FbiValidates { get; set; }

        [JsonPropertyName("lrsNumber")] public string LrsNumber { get; set; } = "            ";

        [JsonIgnore] public bool OfficerDidAssignNibrs { get; set; } = true;

        [JsonIgnore] public string Inchoate { get; set; } = " ";

        [JsonIgnore] public string OffenseGroup { get; set; } = " ";
        
        public Offense()
        {
            SegmentDescriptor = "20";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 16));
            Padding = string.Concat(Enumerable.Repeat(" ", 68));
        }
        
        public void FixPaddings()
        {
            // If seqNum is not provided set it to "   "
            //OffenseSeqNum = OffenseSeqNum.PadL(3, '0');
            LrsNumber = LrsNumber.PadR(12);
            //AttemptedCompleted = AttemptedCompleted.PadR(1).ToUpper();
            // If seqNum is not provided set it to "   "
            //OffConnectToVic = OffConnectToVic.PadL(3, '0');
            //LocationType = LocationType.PadR(2);
            //Premises = Premises.PadR(2);
            CriminalActivity.ForEach( val => val.PadR(1));
            Weapons.ForEach(val => val.WeaponForce?.ToString()?.PadR(3));
            MethodOfEntry = MethodOfEntry.PadR(1);
            AgencyAssignedNibrs = AgencyAssignedNibrs.PadR(3);
            Inchoate = Inchoate.PadR(2);
        }
    }

    public class Weapon
    {
        [JsonPropertyName("weaponForce")] public int? WeaponForce { get; set; }
        
        [JsonPropertyName("automatic")] public bool? AutomaticFirearm { get; set; }

        [JsonPropertyName("stolenFirearm")] public bool? StolenFirearm { get; set; }

        [JsonPropertyName("dischargedFirearm")] public bool? DischargedFirearm { get; set; }

    }
}