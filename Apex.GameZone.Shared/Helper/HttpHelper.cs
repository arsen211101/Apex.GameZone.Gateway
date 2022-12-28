namespace Apex.GameZone.Shared.Helper
{
    public class HttpHelper
    {
        public static System.Net.Http.Headers.AuthenticationHeaderValue AuthenticationHeaderValueBuilder(string accessToken)
        {
            System.Net.Http.Headers.AuthenticationHeaderValue authorization = null;
            if (!string.IsNullOrEmpty(accessToken))
                authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            return authorization;
        }
    }
}
