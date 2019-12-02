using Microsoft.VisualStudio.TestTools.UnitTesting;
using Topic_3_in_out_ref_;

namespace UnitTestTopic_3_in_out_ref_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int a = 1;
			int b = 2;
			int sum = 3;
			int product = 4;
			Program.Operation(a, b, out sum, out product);
			Assert.AreEqual((a + b), sum);
			Assert.AreEqual((a*b), product);
			
		}
	}
}
