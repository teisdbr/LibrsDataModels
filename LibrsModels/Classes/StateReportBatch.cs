using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using NibrsModels.NibrsReport.Item;
using NibrsModels.NibrsReport.Person;
using NibrsModels.NibrsReport.Subject;


namespace LibrsModels.Classes
{
    public class StateReportBatch : IRootValidationObject<ILibrsIncident>
    {
        public string StateReportingSpec => "2.5";

        /// <summary>
        ///     This is the same as ORI, it will be used to report to FBI via NIBRS
        /// </summary>
        public string ReportingId { get; set; }

        /// <summary>
        /// This is the reporting period to which all of the incidents being reported belong to
        /// </summary>
        public DateTime ReportingDate { get; set; } // ReportDate?

        public List<StateReport> StateReports { get; set; }

        #region IRootValidationObject Implementation
        
        [JsonPropertyName("spec")]
        string IRootValidationObject<ILibrsIncident>.Spec { get; set; }
        
        [JsonPropertyName("ori")]
        string IRootValidationObject<ILibrsIncident>.Ori { get; set; }
        [JsonPropertyName("reportYear")]
        int IRootValidationObject<ILibrsIncident>.ReportYear { get; set; }
        [JsonPropertyName("reportMonth")]
        int IRootValidationObject<ILibrsIncident>.ReportMonth { get; set; }

        public string AgencyName { get; set; }
        public string SoftwareID { get; set; }
        public string SoftwareVersion { get; set; }

        [JsonPropertyName("forSubmission")]
        bool IRootValidationObject<ILibrsIncident>.ForSubmission { get; set; } // False for now
        // api/jsonValidator?validateOnly=true
        [JsonPropertyName("incidentList")]
        List<ILibrsIncident> IRootValidationObject<ILibrsIncident>.IncidentList { get; set; }

        [JsonPropertyName("zeroReport")]
        bool IRootValidationObject<ILibrsIncident>.ZeroReport { get; set; }

        #endregion
    }
}