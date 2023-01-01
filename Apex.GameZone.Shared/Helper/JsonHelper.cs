using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Apex.GameZone.Shared.Helper;

public static class JsonHelper
{
    private static readonly JsonSerializerSettings JsonSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        MissingMemberHandling = MissingMemberHandling.Ignore,
        DateFormatHandling = DateFormatHandling.IsoDateFormat,
        DateFormatString = DateTimeFormats.IsoFormat,
        DateTimeZoneHandling = DateTimeZoneHandling.Utc,
        ContractResolver = new PrivateResolver(),
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
    };

    public static TResponse JsonDeserializeToModel<TResponse>(string httpResult)
    {
        var httpResultNullReplaced = httpResult.Replace("\"NaN\"", "null").Replace("Infinity", "-1");
        return JsonConvert.DeserializeObject<TResponse>(httpResultNullReplaced, JsonSettings);
    }

    public static string SerializeToJsonString<TRequest>(TRequest model)
    {
        return JsonConvert.SerializeObject(model, JsonSettings);
    }

    private class PrivateResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            if (!prop.Writable)
            {
                var property = member as PropertyInfo;
                var hasPrivateSetter = property?.GetSetMethod(true) != null;
                prop.Writable = hasPrivateSetter;
            }

            return prop;
        }
    }
}