﻿using Microsoft.Extensions.DependencyInjection;
using Limbo.Umbraco.Time.Providers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Limbo.Umbraco.Time.Composers {

    internal class TimeComposer : IComposer {

        public void Compose(IUmbracoBuilder builder) {

            // Register the default time zone provider with the DI container
            builder.Services.AddSingleton<ITimeZoneProvider, DefaultTimeZoneProvider>();

        }

    }

}