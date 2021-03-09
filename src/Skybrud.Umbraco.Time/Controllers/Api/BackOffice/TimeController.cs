using System.Web.Http;
using Skybrud.Umbraco.Time.Providers;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

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
            return Json(_timeZoneProvider.GetTimeZones());
        }

        #endregion

    }

}