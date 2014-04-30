using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Activation;

namespace ConsoleApplication1
{
	public static class TestDummy : ITest
	{
		public static Test2 GetDummy(IContext context)
		{
			return new Test2()
			{
				Id = 777,
				Name = "advice",
			};
		}

		public int Id
		{
			get
			{
				return 999;
			}
			set
			{
				Id = value;
			}
		}

		public string Name
		{
			get
			{
				return "douctj google";
			}
			set
			{
				Name = value;
			}
		}

		public string GetValue()
		{
			return "apple juice";
		}
	}
}
