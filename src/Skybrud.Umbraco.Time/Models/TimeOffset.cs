using System;
using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters;
using Skybrud.Umbraco.Time.PropertyEditors.TimeOffset;

namespace Skybrud.Umbraco.Time.Models {

    [JsonConverter(typeof(ToStringJsonConverter))]
    public class TimeOffset {

        private readonly TimeSpan _time;

        private readonly string _format;

        public int Hours => _time.Hours;

        public int Minutes => _time.Minutes;

        public TimeOffset(TimeSpan time, TimeOffsetConfiguration configuration) {
            _time = time;
            _format = string.IsNullOrWhiteSpace(configuration?.OutputFormat) ? "hh\\:mm" : configuration.OutputFormat;
        }

        public override string ToString() {
            return _time.ToString(_format);
        }

    }

}