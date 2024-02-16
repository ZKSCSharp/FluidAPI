using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace FluidAPI.APICall
{
    public class API
    {
        public delegate void OnConnect(string res);
        public static void Connect(List<APIField> fields, string apiname, string url, OnConnect response)
        {
            Thread rq = new Thread(new ThreadStart(async () =>
            {
                string res;
                HttpClient httpClient = new HttpClient();
                string json = JsonHelper.JsonBuilder(fields);

                var vals = new Dictionary<string, string> { { apiname, json } };
                var content = new FormUrlEncodedContent(vals);
                var resp = await httpClient.PostAsync(url, content);
                res = await resp.Content.ReadAsStringAsync();

                response(res);
            }));
        }
    }
}
