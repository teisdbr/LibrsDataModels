using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Admin : LegacyLibrsValues, IPaddingFixer
    {
        [JsonPropertyName("location")] public string Location { get; set; } = "            ";

        [JsonPropertyName("stationID")] public string StationID { get; set; } = "      ";

        /// <summary>
        /// Stores the incident date or incident reported date as indicated by IsReportingDate property
        /// </summary>
        [JsonPropertyName("incidentDate")]
        public DateTime? IncidentDate { get; set; }

        /// <summary>
        /// Indicates whether or not the incident date provided in this object is actually the reporting date.
        /// The default value is false.
        /// </summary>
        [JsonPropertyName("isReportingDate")]
        public bool IsReportingDate { get; set; }

        [JsonPropertyName("clearedExceptionally")] public string ClearedExceptionally { get; set; } = "N";

        [JsonPropertyName("excpClearDate")] public DateTime? ExcpClearDate { get; set; }

        [JsonPropertyName("cargoTheft")] public bool? CargoTheft { get; set; }

        [JsonIgnore] public bool HasGroupAOffense { get; set; }

        public Admin()
        {
            SegmentDescriptor = "10";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 84));
        }

        public void FixPaddings()
        {
            Location = Location.PadR(12);
            StationID = StationID.PadR(6);
            ClearedExceptionally = ClearedExceptionally.PadR(1);
        }
    }
}