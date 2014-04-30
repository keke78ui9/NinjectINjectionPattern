using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class Test2 : ITest
	{
		public int Id
		{
			get
			{
				return 1;
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
				return "my name";
			}
			set
			{
				Name = value;
			}
		}

		public string GetValue()
		{
			return "Hi";
		}
	}
}
