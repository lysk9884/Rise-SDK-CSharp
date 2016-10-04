namespace RiseSDK
{
	public partial class risesdk
	{
		public partial class api
		{
			public class loader
			{
				public static dynamic status()
				{
					return Helpers.request("GET", "/api/loader/status");
				}

				public static dynamic syncStatus()
				{
					return Helpers.request("GET", "/api/loader/status/sync");
				}
			}
		}
	}
}