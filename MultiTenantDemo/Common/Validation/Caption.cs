using System;
using System.Resources;
using System.Threading;

namespace Me.Sample.Common.Resource
{
	public class Caption
	{
		[ThreadStatic]
		public static ResourceManager ResourceManager = null;

		public static string Company
		{
			get
			{
				return ResourceManager.GetString("Company");
			}
		}
	}
}
