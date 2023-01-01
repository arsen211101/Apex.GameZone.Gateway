using System.Net.Http.Headers;

namespace Apex.GameZone.Shared.Helper;

public class HttpHelper
{
    public static AuthenticationHeaderValue AuthenticationHeaderValueBuilder(string accessToken)
    {
        AuthenticationHeaderValue authorization = null;
        if (!string.IsNullOrEmpty(accessToken))
            authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        return authorization;
    }
}