using System.Collections.Generic;
using Skybrud.Umbraco.Time.Models.TimeZones;

namespace Skybrud.Umbraco.Time.Providers {
    
    public interface ITimeZoneProvider {

        IEnumerable<ITimeZone> GetTimeZones();
        
        bool TryGetTimeZone(string id, out ITimeZone result);

    }

}