using Microsoft.AspNetCore.Mvc;
using Skybrud.Umbraco.Time.Providers;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;

#pragma warning disable 1591

namespace Skybrud.Umbraco.Time.Controllers.Api.BackOffice {

    [PluginController("Skybrud")]
    public class TimeController : UmbracoAuthorizedApiController {

        private readonly ITimeZoneProvider _timeZoneProvider;

        #region Constructors

        public TimeController(ITimeZoneProvider timeZoneProvider) {
            _timeZoneProvider = timeZoneProvider;
        }

        #endregion

        #region Public API methods

        [HttpGet]
        public object GetTimeZones() {
            return _timeZoneProvider.GetTimeZones();
        }

        #endregion

    }

}