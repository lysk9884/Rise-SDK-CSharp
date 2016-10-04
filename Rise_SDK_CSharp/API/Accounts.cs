namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class accounts
			{
				public static dynamic open(string secret)
				{
					return Helpers.request("POST", "/api/accounts/open", new { secret = secret });
				}

				public static dynamic getBalance(string address)
				{
					return Helpers.request("GET", "/api/accounts/getBalance?address=" + address);
				}

				public static dynamic getPublicKey(string address)
				{
					return Helpers.request("GET", "/api/accounts/getPublicKey?address=" + address);
				}

				public static dynamic generatePublicKey(string secret)
				{
					return Helpers.request("POST", "/api/accounts/generatePublicKey", new { secret = secret });
				}

				public static dynamic getAccount(string address)
				{
					return Helpers.request("GET", "/api/accounts?address=" + address);
				}

				public static dynamic getDelegates(string address)
				{
					return Helpers.request("GET", "/api/accounts/delegates?address=" + address);
				}

				public static dynamic putDelegates(string secret, string publicKey, string delegates, string secondSecret = null)
				{
					dynamic options = new { secret = secret, publicKey = publicKey, delegates = delegates };
					if (secondSecret != null)
					{
						options = new { secret = secret, publicKey = publicKey, delegates = delegates, secondSecret = secondSecret };
					}
					return Helpers.request("PUT", "/api/accounts/delegates", options);
				}
			}
		}
	}
}