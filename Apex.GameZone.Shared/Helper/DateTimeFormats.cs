using Newtonsoft.Json;

namespace Apex.GameZone.Shared.Helper;

public class DateTimeFormats
{
    public const string IsoFormat = "yyyy-MM-ddTHH:mm:ss";
    public const string DisplayFormat = "dd-MM-yyyy";

    public static JsonSerializerSettings NsJsonFormatSettingsForDate
        => new()
        {
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateFormatString = IsoFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc
        };

    public static JsonSerializerSettings NsJsonFormatSettingsForDateIgnoreNull
        => new()
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateFormatString = IsoFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc
        };
}