using Skybrud.Umbraco.Time.Providers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.Time.Composers {

    public class TimeComposer : IUserComposer {

        public void Compose(IUmbracoBuilder builder) {
            
            // Register the default time zone provider with dependency injection
            builder.Services.AddUnique<ITimeZoneProvider, DefaultTimeZoneProvider>();

        }

    }

}