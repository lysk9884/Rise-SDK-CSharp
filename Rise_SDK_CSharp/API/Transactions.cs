namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class transactions
			{
				public static dynamic getList(string blockId = null, string recipientId = null,
									 string senderId = null, int? limit = null,
									 int? offset = null, string orderBy = null)
				{
					string query = "";

					if (blockId != null)
					{
						query = Helpers.addToQuery(query, "blockId", blockId);
					}
					if (recipientId != null)
					{
						query = Helpers.addToQuery(query, "recipientId", recipientId);
					}
					if (senderId != null)
					{
						query = Helpers.addToQuery(query, "senderId", senderId);
					}
					if (orderBy != null)
					{
						query = Helpers.addToQuery(query, "orderBy", orderBy);
					}
					if (limit != null)
					{
						query = Helpers.addToQuery(query, "limit", limit.ToString());
					}
					if (offset != null)
					{
						query = Helpers.addToQuery(query, "offset", offset.ToString());
					}

					return Helpers.request("GET", "/api/transactions" + query);
				}

				public static dynamic send(string secret, int amount, string recipientId, string publicKey, string secondSecret = null)
				{
					dynamic options = new { secret = secret, amount = amount, recipientId = recipientId, publicKey = publicKey };
					if (secondSecret != null)
					{
						options = new { secret = secret, amount = amount, recipientId = recipientId, publicKey = publicKey, secondSecret = secondSecret };
					}
					return Helpers.request("PUT", "/api/transactions", options);
				}

				public static dynamic get(string id)
				{
					return Helpers.request("GET", "/api/transactions/get?id=" + id);
				}

				public static dynamic getUnconfirmed(string id)
				{
					return Helpers.request("GET", "/api/transactions/unconfirmed/get?id=" + id);
				}

				public static dynamic getUnconfirmedList()
				{
					return Helpers.request("GET", "/api/transactions/unconfirmed");
				}
			}
		}
	}
}

