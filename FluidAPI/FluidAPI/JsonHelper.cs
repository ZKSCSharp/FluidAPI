using FluidAPI.APICall;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace FluidAPI
{
    public class JsonHelper
    {
        public static string JsonBuilder(List<APIField> requestFields)
        {
            string json = string.Empty;

            for (int i = 0; i < requestFields.Count; i++)
            {
                if (i == 0 && requestFields[i] == requestFields.Last())
                { json += "{" + $"\"{requestFields[i].Name}\":\"{requestFields[i].Value}\"" + "}"; }

                if (i == 0 && requestFields[i] != requestFields.Last())
                { json += "{" + $"\"{requestFields[i].Name}\":\"{requestFields[i].Value}\","; }

                if (requestFields[i] == requestFields.Last() && i != 0)
                { json += $"\"{requestFields[i].Name}\":\"{requestFields[i].Value}\"" + "}"; }

                if (i > 0 && requestFields[i] != requestFields.Last())
                { json += $"\"{requestFields[i].Name}\":\"{requestFields[i].Value}\","; }
            }

            return json;
        }

        public static List<string> DecodeJson(string json)
        {
            List<string> deccode = new List<string>();
            JsonObject res = (JsonObject)JsonObject.Parse(json);
            string imgUrl = (string)res["img"];
            string name = (string)res["name"];

            deccode.Add(imgUrl);
            deccode.Add(name);
            return deccode;
        }
    }
}
