namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class signatures
			{
				public static dynamic get(string id)
				{
					return Helpers.request("GET", "/api/signatures/get?id=" + id);
				}

				public static dynamic add(string secret, string secondSecret, string publicKey = null)
				{
					dynamic options = new { secret = secret, secondSecret = secondSecret };
					if (publicKey != null)
					{
						options = new { secret = secret, publicKey = publicKey, secondSecret = secondSecret };
					}
					return Helpers.request("PUT", "/api/signatures", options);
				}
			}
		}
	}
}