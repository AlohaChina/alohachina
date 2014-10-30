using System;
using System.Resources;
using System.Threading;

namespace Me.Sample.Common.Resource
{
	public class Message
	{
		[ThreadStatic]
		public static ResourceManager ResourceManager = null;

		public static string Test
		{
			get
			{
				return ResourceManager.GetString("Test");
			}
		}
	}
}
