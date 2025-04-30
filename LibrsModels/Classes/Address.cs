using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibrsModels.Classes
{
    public class Address
    {
        [JsonPropertyName("street")] public string Street { get; set; }

        [JsonPropertyName("city")] public string City { get; set; }

        [JsonPropertyName("state")] public string State { get; set; }

        [JsonPropertyName("zip")] public int? Zip { get; set; }

        [JsonPropertyName("zipExt")] public int? ZipExt { get; set; }

        public override string ToString()
        {
            var addressString = "";
            if (!string.IsNullOrWhiteSpace(Street))
                addressString += Street;
            if (!string.IsNullOrWhiteSpace(City))
                addressString += ", " + City;
            if (!string.IsNullOrWhiteSpace(State))
                addressString += " " + State;
            if (Zip.HasValue)
                addressString += " " + Zip.Value;
            return addressString;
        }
    }
}