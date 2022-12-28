namespace Apex.GameZone.Shared.Helper
{
    public static class JsonHelper
    {
        public static TResponse JsonDeserializeToModel<TResponse>(string httpResult)
        {
            var httpResultNullReplaced = httpResult.Replace("\"NaN\"", "null").Replace("Infinity", "-1");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TResponse>(httpResultNullReplaced, JsonSettings);
        }

        public static string SerializeToJsonString<TRequest>(TRequest model)
            => Newtonsoft.Json.JsonConvert.SerializeObject(model, JsonSettings);

        private static readonly Newtonsoft.Json.JsonSerializerSettings JsonSettings = new Newtonsoft.Json.JsonSerializerSettings
        {
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
            DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
            DateFormatString = DateTimeFormats.IsoFormat,
            DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
            ContractResolver = new PrivateResolver(),
            ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        private class PrivateResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
        {
            protected override Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization)
            {
                var prop = base.CreateProperty(member, memberSerialization);
                if (!prop.Writable)
                {
                    var property = member as System.Reflection.PropertyInfo;
                    var hasPrivateSetter = property?.GetSetMethod(true) != null;
                    prop.Writable = hasPrivateSetter;
                }
                return prop;
            }
        }
    }
}
