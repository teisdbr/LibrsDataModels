using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public interface ILibrsIncident
    {
        string ActionType { get; }
        string IncidentNumber { get; }
        Admin Admin { get; }
        List<Offense> Offense { get; }
        PropertySeg PropertySeg { get; }
        List<PropDesc> PropDesc { get; }
        List<PropertyOffense> PropertyOffense { get; }
        List<Offender> Offender { get; }
        //List<OffUsing> OffUsing { get; }
        List<Victim> Victim { get; }
        // List<VicInjury> VicInjury { get; }
        // List<VicOff> VicOff { get; }
        List<Arrestee> Arrestee { get; }
        //List<ArrArm> ArrArm { get; }
        //List<ArrStatute> ArrStatute { get; }
 

        
        /// <summary>
        /// List of errors as returned by the validation server
        /// </summary>
        List<Error> Errors { get; }
        
        /// <summary>
        /// List of warnings as returned by the validation server.
        /// </summary>
        List<Warning> Warnings { get; }
    }

    public class LibrsIncident : ILibrsIncident, IPaddingFixer
    {
        [JsonPropertyName("actionType")]
        public string ActionType { get; set; }
        
        [JsonPropertyName("incidentNumber")]
        public string IncidentNumber { get; set; }
        
        [JsonPropertyName("hasErrors")]
        public bool HasErrors { get; set; }
        
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
        
        [JsonPropertyName("warnings")]
        public List<Warning> Warnings { get; set; }

        [JsonPropertyName("admin")] public Admin Admin { get; set; }

        [JsonPropertyName("adminMod")]
        public AdminMod AdminMod { get; set; }

        [JsonPropertyName("offense")]
        public List<Offense> Offense { get; set; }
        
        [JsonPropertyName("propertySeg")]
        public PropertySeg PropertySeg { get; set; }
        
        [JsonPropertyName("propDesc")]
        public List<PropDesc> PropDesc { get; set; }
        
        [JsonPropertyName("propMod")]
        public PropMod PropMod { get; set; }
        
        [JsonPropertyName("propertyOffense")]
        public List<PropertyOffense> PropertyOffense { get; set; }
        
        [JsonPropertyName("offender")]
        public List<Offender> Offender { get; set; }
        
        // This is no longer in use in LIBRS, but I've left it here in case
        // it's helpful to someone later down the line.
        // [JsonPropertyName("offUsing")]
        // public List<OffUsing> OffUsing { get; set; }
        
        [JsonPropertyName("victim")]
        public List<Victim> Victim { get; set; }
        
        // This is also no longer used in the JSON Model for LIBRS, but if it's
        // valuable to someone down the line, have at.
        // [JsonPropertyName("vicInjury")]
        // public List<VicInjury> VicInjury { get; set; }
        
        //[JsonPropertyName("vicOff")]
        //public List<VicOff> VicOff { get; set; }
        
        [JsonPropertyName("arrestee")]
        public List<Arrestee> Arrestee { get; set; }

        //[JsonPropertyName("arrArm")]
        //public List<ArrArm> ArrArm { get; set; }

        //[JsonPropertyName("arrStatute")]
        //public List<ArrStatute> ArrStatute { get; set; }
        
        [JsonPropertyName("arrMod")]
        public ArrMod ArrMod { get; set; }
        
        [JsonPropertyName("inchoate")]
        public bool Inchoate { get; set; }
        
        [JsonPropertyName("propertyLossTypeFlags")]
        public object PropertyLossTypeFlags { get; set; }

        [JsonIgnore]
        public bool InsertedtoDB { get; set; }

        [JsonIgnore]
        public bool DidCachePropertyLossTypes { get; set; }

        [JsonIgnore]
        public string EntireLineSegments { get; set; }

        public void FixPaddings()
        {
            ActionType = ActionType.PadR(1);
            IncidentNumber = IncidentNumber.PadR(12);
        }
    }
}