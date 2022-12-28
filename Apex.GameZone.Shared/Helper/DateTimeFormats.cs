using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.GameZone.Shared.Helper
{
    public class DateTimeFormats
    {
        public const string IsoFormat = "yyyy-MM-ddTHH:mm:ss";
        public const string DisplayFormat = "dd-MM-yyyy";

        public static Newtonsoft.Json.JsonSerializerSettings NsJsonFormatSettingsForDate
            => new Newtonsoft.Json.JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateFormatString = IsoFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc
            };

        public static Newtonsoft.Json.JsonSerializerSettings NsJsonFormatSettingsForDateIgnoreNull
            => new Newtonsoft.Json.JsonSerializerSettings
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateFormatString = IsoFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc
            };
    }
}
