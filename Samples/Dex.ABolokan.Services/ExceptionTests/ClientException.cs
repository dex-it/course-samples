using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.ExceptionTests
{
	public class ClientException : ArgumentException
	{
		public ClientException(string message) : base(message)
		{

		}
	}
}
