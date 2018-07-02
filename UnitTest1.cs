using System;
using Xunit;

namespace dotnetProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
		int a = 10;
		int b = a + 2;
		Console.Write(b + a);
        }

        public void Test2()
        {
		int a = 10;
		int b = a + 2;
		Console.Write(b + a);
        }

        public void Test3()
        {
        }

	[Fact]
	public void TestFail() 
	{
		throw new Exception();
	}
    }
}
