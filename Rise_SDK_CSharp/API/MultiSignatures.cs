namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class multiSignatures
			{
				public static dynamic getPending(string publicKey)
				{
					return Helpers.request("GET", "/api/multisignatures/pending?publicKey=" + publicKey);
				}

				public static dynamic create(string secret, int lifetime, int min, string[] keysGroup)
				{
					return Helpers.request("PUT", "/api/multisignatures", new { secret = secret, lifetime = lifetime, min = min, keysgroup = keysGroup });
				}

				public static dynamic sign(string secret, string publicKey, string transactionId)
				{
					return Helpers.request("POST", "/api/multisignatures/sign", new { secret = secret, publicKey = publicKey, transactionId = transactionId });
				}

				public static dynamic getAccounts(string publicKey)
				{
					return Helpers.request("GET", "/api/multisignatures/accounts?publicKey=" + publicKey);
				}
			}
		}
	}
}