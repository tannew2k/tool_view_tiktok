using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace tool_view_tiktok.ApiOmniLogin
{
    public class ApiOmniLogin
    {
        private static string BASE_URL = "http://localhost:35353";
        public async static Task<JToken> GetProfileOmniLogin(string sortType)
        {
            var client = new RestClient($"{BASE_URL}/profiles?sort=date_created&sort_type={sortType}");
            var request = new RestRequest("", Method.Get);
            var response = await client.ExecuteAsync<RestRequest>(request);
            if (response.IsSuccessful)
            {
                var details = JObject.Parse(response.Content);
                var docs = details["docs"];
                return docs;
            }
            return null;
        }

        public async static Task<JToken> OpenProfileOmniLogin(string id)
        {
            var client = new RestClient($"{BASE_URL}/open?profile_id={id}");
            var request = new RestRequest("", Method.Get);
            var response = await client.ExecuteAsync<RestRequest>(request);
            if (response.IsSuccessful)
            {
                var profileBrowser = JObject.Parse(response.Content);
                return profileBrowser;
            }
            return null;
        }
    }
}