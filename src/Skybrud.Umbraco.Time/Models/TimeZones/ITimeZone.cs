using System;
using Newtonsoft.Json;

namespace Skybrud.Umbraco.Time.Models.TimeZones {
    
    public interface ITimeZone {

        [JsonProperty("id")]
        string Id { get; }

        [JsonProperty("name")]
        string Name { get; }

        [JsonIgnore]
        TimeZoneInfo TimeZoneInfo { get; }

    }

}