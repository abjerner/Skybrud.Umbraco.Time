using System;
using System.Text.Json.Serialization;

namespace Skybrud.Umbraco.Time.Models.TimeZones {
    
    public interface ITimeZone {
        
        string Id { get; }
        
        string Name { get; }

        [JsonIgnore]
        TimeZoneInfo TimeZoneInfo { get; }

    }

}