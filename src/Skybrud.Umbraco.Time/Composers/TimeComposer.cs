using Skybrud.Umbraco.Time.Providers;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Skybrud.Umbraco.Time.Composers {

    [RuntimeLevel(MinLevel = RuntimeLevel.Boot)]
    public class TimeComposer : IUserComposer {

        public void Compose(Composition composition) {

            // Register the default time zone provider with dependency injection
            composition.Register<ITimeZoneProvider, DefaultTimeZoneProvider>(Lifetime.Singleton);

        }

    }

}
