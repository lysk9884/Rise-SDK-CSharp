namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class peers
			{
				public static dynamic getList(string os = null, int? state = null,
									 string version = null, int? limit = null,
									 int? offset = null, string orderBy = null)
				{
					string query = "";

					if (os != null)
					{
						query = Helpers.addToQuery(query, "os", os);
					}
					if (version != null)
					{
						query = Helpers.addToQuery(query, "version", version);
					}
					if (orderBy != null)
					{
						query = Helpers.addToQuery(query, "orderBy", orderBy);
					}
					if (state != null)
					{
						query = Helpers.addToQuery(query, "state", state.ToString());
					}
					if (limit != null)
					{
						query = Helpers.addToQuery(query, "limit", limit.ToString());
					}
					if (offset != null)
					{
						query = Helpers.addToQuery(query, "offset", offset.ToString());
					}

					return Helpers.request("GET", "/api/peers" + query);
				}

				public static dynamic get(string ip, int port)
				{
					return Helpers.request("GET", "/api/peers/get?ip=" + ip + "&port=" + port.ToString());
				}

				public static dynamic version()
				{
					return Helpers.request("GET", "/api/peers/version");
				}
			}
		}
	}
}