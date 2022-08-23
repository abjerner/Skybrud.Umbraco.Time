using Microsoft.AspNetCore.Mvc;
using Limbo.Umbraco.Time.Providers;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;

#pragma warning disable 1591

namespace Limbo.Umbraco.Time.Controllers.Api.BackOffice {

    [PluginController("Limbo")]
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