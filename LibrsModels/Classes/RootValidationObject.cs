using System;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace LibrsModels.Classes
{
    public class RootValidationObject : IPaddingFixer, IRootValidationObject<LibrsIncident>
    {
        [JsonPropertyName("spec")] public string Spec { get; set; }

        [JsonPropertyName("ori")] public string Ori { get; set; }

        [JsonPropertyName("reportYear")] public int ReportYear { get; set; }

        [JsonPropertyName("reportMonth")] public int ReportMonth { get; set; }

        [JsonPropertyName("agencyName")] public string AgencyName { get; set; }

        [JsonPropertyName("softwareId")] public string SoftwareID { get; set; }

        [JsonPropertyName("softwareVersion")] public string SoftwareVersion { get; set; }

        [JsonPropertyName("forSubmission")] public bool ForSubmission { get; set; }

        [JsonPropertyName("zeroReport")] public bool ZeroReport { get; set; }

        [JsonPropertyName("incidentList")] public List<LibrsIncident> IncidentList { get; set; }

        public void FixPaddings()
        {
            #region Fixing Paddings For RootObject

            Ori = Ori.PadLeft(1);

            #endregion

            #region Fix Padding For Children

            Recursive(this);

            #endregion
        }

        private void Recursive(object il)
        {
            // Get all the properties of the object
            foreach (var inc in il.GetType().GetProperties())
            {
                try
                {
                    var propertyValue = inc.GetValue(il);
                    if (propertyValue != null)
                    {
                        // For each property check if the property implements the IPaddingFixer Interface
                        if (typeof(IPaddingFixer).IsAssignableFrom(inc.PropertyType))
                        {
                            // If it implements the desired interface then extract value of the property
                            IPaddingFixer converter = (IPaddingFixer) propertyValue;
                            // Call the FixPadding function implemented by the interface
                            converter.FixPaddings();
                            // call Recursive function so that all the properties
                            // which implement IPaddingFixer interface inside this property
                            Recursive(converter);
                        }

                        // For each property check if it a list
                        if (inc.PropertyType.IsGenericType &&
                            (inc.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
                        {
                            // Get the value of the list and cast as list
                            var segList = ((IEnumerable) propertyValue)?.Cast<object>().ToList();
                            segList?.ForEach(sl =>
                            {
                                // For each value in the list check if they implement IPaddingFixer Interface
                                if (sl is IPaddingFixer)
                                {
                                    var converter = (IPaddingFixer) sl;
                                    // Call the FixPadding function implemented by the interface
                                    converter.FixPaddings();
                                    // call Recursive function so that all the properties
                                    // which implement IPaddingFixer interface inside this property
                                    Recursive(converter);
                                }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + " at " + inc.Name);
                    throw new Exception(ex.Message + " at " + inc.Name + " stack trace:" + ex.StackTrace,
                        ex.InnerException);

                }
            }
        }
    }
}