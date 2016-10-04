using System;
using RiseSDK;

namespace Rise_SDK_CSharp_Tests
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			risesdk.setHost("http://localhost:4444");
			Console.WriteLine(risesdk.api.loader.status());
		}
	}
}
