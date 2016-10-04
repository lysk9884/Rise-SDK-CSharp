using Newtonsoft.Json;
using RestSharp;

namespace RiseSDK
{
	internal static class Helpers
	{
		public static RestClient client;

		public static dynamic request(string type, string url, dynamic data = null)
		{
			RestRequest req;
			if (type.ToUpper() == "POST")
			{
				req = new RestRequest(url, Method.POST);
			}
			else if (type.ToUpper() == "PUT")
			{
				req = new RestRequest(url, Method.PUT);
			}
			else
			{
				req = new RestRequest(url, Method.GET);
			}
			if (data != null)
			{
				req.RequestFormat = DataFormat.Json;
				req.AddBody(data);
			}
			IRestResponse response = client.Execute(req);
			return JsonConvert.DeserializeObject(response.Content);
		}

		public static string addToQuery(string query, string name, string param)
		{
			if (query.Length == 0)
			{
				query += "?";
			}
			else
			{
				query += "&";
			}

			query += name + "=" + param;

			return query;
		}
	}
}