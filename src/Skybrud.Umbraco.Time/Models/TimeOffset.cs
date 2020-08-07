using System;
using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters;

namespace Skybrud.Umbraco.Time.Models {

    [JsonConverter(typeof(ToStringJsonConverter))]
    public class TimeOffset {

        private TimeSpan _time;

        public int Hours => _time.Hours;

        public int Minutes => _time.Minutes;

        public TimeOffset(TimeSpan time) {
            _time = time;
        }

        public override string ToString() {
            return _time.ToString();
        }

    }

}