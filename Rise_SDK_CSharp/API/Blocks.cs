namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class blocks
			{
				public static dynamic get(string id)
				{
					return Helpers.request("GET", "/api/blocks/get?id=" + id);
				}

				public static dynamic getList(string generatorPublicKey = null, int? totalFee = null,
											 int? totalAmount = null, string previousBlock = null,
											 int? height = null, int? limit = null,
											 int? offset = null, string orderBy = null)
				{
					string query = "";

					if (generatorPublicKey != null)
					{
						query = Helpers.addToQuery(query, "generatorPublicKey", generatorPublicKey);
					}
					if (previousBlock != null)
					{
						query = Helpers.addToQuery(query, "previousBlock", previousBlock);
					}
					if (orderBy != null)
					{
						query = Helpers.addToQuery(query, "orderBy", orderBy);
					}
					if (totalFee != null)
					{
						query = Helpers.addToQuery(query, "totalFee", totalFee.ToString());
					}
					if (totalAmount != null)
					{
						query = Helpers.addToQuery(query, "totalAmount", totalAmount.ToString());
					}
					if (height != null)
					{
						query = Helpers.addToQuery(query, "height", height.ToString());
					}
					if (limit != null)
					{
						query = Helpers.addToQuery(query, "limit", limit.ToString());
					}
					if (offset != null)
					{
						query = Helpers.addToQuery(query, "offset", offset.ToString());
					}

					return Helpers.request("GET", "/api/blocks" + query);
				}

				public static dynamic getFee()
				{
					return Helpers.request("GET", "/api/blocks/getFee");
				}

				public static dynamic getFeesSchedule()
				{
					return Helpers.request("GET", "/api/blocks/getFees");
				}

				public static dynamic getReward()
				{
					return Helpers.request("GET", "/api/blocks/getReward");
				}

				public static dynamic getSupply()
				{
					return Helpers.request("GET", "/api/blocks/getSupply");
				}

				public static dynamic getHeight()
				{
					return Helpers.request("GET", "/api/blocks/getHeight");
				}

				public static dynamic getStatus()
				{
					return Helpers.request("GET", "/api/blocks/getStatus");
				}

				public static dynamic getNethash()
				{
					return Helpers.request("GET", "/api/blocks/getNethash");
				}

				public static dynamic getMilestone()
				{
					return Helpers.request("GET", "/api/blocks/getMilestone");
				}
			}
		}
	}
}