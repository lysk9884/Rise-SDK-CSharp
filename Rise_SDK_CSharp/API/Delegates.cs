namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class delegates
			{
				public static dynamic enable(string secret, string secondSecret, string username)
				{
					return Helpers.request("PUT", "/api/delegates", new { secret = secret, secondSecret = secondSecret, username = username });
				}

				public static dynamic getList(int? limit = null, int? offset = null, string orderBy = null)
				{
					string query = "";
					if (limit != null)
					{
						query = Helpers.addToQuery(query, "limit", limit.ToString());
					}
					if (offset != null)
					{
						query = Helpers.addToQuery(query, "offset", offset.ToString());
					}
					if (orderBy != null)
					{
						query = Helpers.addToQuery(query, "orderBy", orderBy);
					}
					return Helpers.request("GET", "/api/delegates" + query);
				}

				public static dynamic getByPublicKey(string publicKey)
				{
					return Helpers.request("GET", "/api/delegates/get?publicKey=" + publicKey);
				}

				public static dynamic getByUsername(string username)
				{
					return Helpers.request("GET", "/api/delegates/get?username=" + username);
				}

				public static dynamic count()
				{
					return Helpers.request("GET", "/api/delegates/count");
				}

				public static dynamic getVoters(string publicKey)
				{
					return Helpers.request("GET", "/api/delegates/voters?publicKey=" + publicKey);
				}

				public static dynamic enableForging(string secret)
				{
					return Helpers.request("POST", "/api/delegates/forging/enable", new { secret = secret });
				}

				public static dynamic disableForging(string secret)
				{
					return Helpers.request("POST", "/api/delegates/forging/disable", new { secret = secret });
				}

				public static dynamic getForgedByAccount(string generatorPublicKey)
				{
					return Helpers.request("POST", "/api/delegates/forging/getForgedByAccount?generatorPublicKey=" + generatorPublicKey);
				}
			}
		}
	}
}