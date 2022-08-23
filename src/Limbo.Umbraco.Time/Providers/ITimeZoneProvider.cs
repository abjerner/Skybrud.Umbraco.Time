using System.Collections.Generic;
using Limbo.Umbraco.Time.Models.TimeZones;

namespace Limbo.Umbraco.Time.Providers {

    /// <summary>
    /// Interface describing a time zone provider.
    /// </summary>
    public interface ITimeZoneProvider {

        /// <summary>
        /// Returns the time zones of the provider.
        /// </summary>
        /// <returns>A collection of <see cref="ITimeZone"/>.</returns>
        IEnumerable<ITimeZone> GetTimeZones();

        /// <summary>
        /// Gets the time zone with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The unique identifier of the time zone.</param>
        /// <param name="result">When this method returns, contains the time zone with the specified <paramref name="id"/>, if the time zone is found; otherwise <c>null</c>. This parameter is passed uninitialized.</param>
        /// <returns><c>true</c> if provider contains a time zone with the specified <paramref name="id"/>; otherwise <c>false</c>.</returns>
        bool TryGetTimeZone(string id, out ITimeZone result);

    }

}