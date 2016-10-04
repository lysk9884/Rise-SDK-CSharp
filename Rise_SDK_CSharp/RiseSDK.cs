using RestSharp;

namespace RiseSDK
{
	public partial class risesdk
	{
		public static void setHost(string host)
		{
			Helpers.client = new RestClient(host);
		}
	}
}