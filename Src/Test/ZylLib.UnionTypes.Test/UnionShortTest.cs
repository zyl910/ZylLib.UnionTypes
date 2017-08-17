using System;
using ZylLib.UnionTypes;
#if NUNIT
using NUnit.Framework;
#elif XUNIT
using Xunit;
using Test = Xunit.FactAttribute;
using Assert = Newtonsoft.Json.Tests.XUnitAssert;
#elif NETFX_CORE
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using TestFixture = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestClassAttribute;
using Test = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestMethodAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFixture = Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute;
#endif

namespace ZylLib.UnionTypes.Test
{
    
    
    /// <summary>
    ///这是 UnionShortTest 的测试类，旨在
    ///包含所有 UnionShortTest 单元测试
    ///</summary>
	[TestFixture()]
	public class UnionShortTest {


		private TestContext testContextInstance;

		/// <summary>
		///获取或设置测试上下文，上下文提供
		///有关当前测试运行及其功能的信息。
		///</summary>
		public TestContext TestContext {
			get {
				return testContextInstance;
			}
			set {
				testContextInstance = value;
			}
		}

		#region 附加测试特性
		// 
		//编写测试时，还可使用以下特性:
		//
		//使用 ClassInitialize 在运行类中的第一个测试前先运行代码
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//使用 ClassCleanup 在运行完类中的所有测试后再运行代码
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//使用 TestInitialize 在运行每个测试前先运行代码
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//使用 TestCleanup 在运行完每个测试后运行代码
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///Equals 的测试
		///</summary>
		[TestMethod()]
		public void EqualsTest() {
			UnionShort target = new UnionShort();
			target.S0 = 0x1234;
			Assert.AreEqual(true, target.Equals(new UnionShort(0x1234)));
			Assert.AreEqual(false, target.Equals(null));
		}

		/// <summary>
		///LoadBytes 的测试
		///</summary>
		public void LoadBytesTestHelper<T>()
			where T : struct {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			T[] src = null; // TODO: 初始化为适当的值
			int expected = 0; // TODO: 初始化为适当的值
			int actual;
			actual = target.LoadBytes<T>(src);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		[TestMethod()]
		public void LoadBytesTest() {
			Assert.Inconclusive("没有找到能够满足 T 的类型约束的相应类型参数。请以适当的类型参数来调用 LoadBytesTestHelper<T>()。");
		}

		/// <summary>
		///LoadBytesAt 的测试
		///</summary>
		public void LoadBytesAtTestHelper<T>()
			where T : struct {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			int offset = 0; // TODO: 初始化为适当的值
			int srcOffset = 0; // TODO: 初始化为适当的值
			int count = 0; // TODO: 初始化为适当的值
			T[] src = null; // TODO: 初始化为适当的值
			int expected = 0; // TODO: 初始化为适当的值
			int actual;
			actual = target.LoadBytesAt<T>(offset, srcOffset, count, src);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		[TestMethod()]
		public void LoadBytesAtTest() {
			Assert.Inconclusive("没有找到能够满足 T 的类型约束的相应类型参数。请以适当的类型参数来调用 LoadBytesAtTestHelper<T>()。");
		}

		/// <summary>
		///SaveBytes 的测试
		///</summary>
		public void SaveBytesTestHelper<T>()
			where T : struct {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			T[] dst = null; // TODO: 初始化为适当的值
			int expected = 0; // TODO: 初始化为适当的值
			int actual;
			actual = target.SaveBytes<T>(dst);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		[TestMethod()]
		public void SaveBytesTest() {
			Assert.Inconclusive("没有找到能够满足 T 的类型约束的相应类型参数。请以适当的类型参数来调用 SaveBytesTestHelper<T>()。");
		}

		/// <summary>
		///SaveBytesAt 的测试
		///</summary>
		public void SaveBytesAtTestHelper<T>()
			where T : struct {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			int offset = 0; // TODO: 初始化为适当的值
			int dstOffset = 0; // TODO: 初始化为适当的值
			int count = 0; // TODO: 初始化为适当的值
			T[] dst = null; // TODO: 初始化为适当的值
			int expected = 0; // TODO: 初始化为适当的值
			int actual;
			actual = target.SaveBytesAt<T>(offset, dstOffset, count, dst);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		[TestMethod()]
		public void SaveBytesAtTest() {
			Assert.Inconclusive("没有找到能够满足 T 的类型约束的相应类型参数。请以适当的类型参数来调用 SaveBytesAtTestHelper<T>()。");
		}

		/// <summary>
		///ToByteArray 的测试
		///</summary>
		[TestMethod()]
		public void ToByteArrayTest() {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			byte[] expected = null; // TODO: 初始化为适当的值
			byte[] actual;
			actual = target.ToByteArray();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		/// <summary>
		///ToInt16Array 的测试
		///</summary>
		[TestMethod()]
		public void ToInt16ArrayTest() {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			short[] expected = null; // TODO: 初始化为适当的值
			short[] actual;
			actual = target.ToInt16Array();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		/// <summary>
		///ToSByteArray 的测试
		///</summary>
		[TestMethod()]
		public void ToSByteArrayTest() {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			sbyte[] expected = null; // TODO: 初始化为适当的值
			sbyte[] actual;
			actual = target.ToSByteArray();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		/// <summary>
		///ToString 的测试
		///</summary>
		[TestMethod()]
		public void ToStringTest() {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			string expected = string.Empty; // TODO: 初始化为适当的值
			string actual;
			actual = target.ToString();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}

		/// <summary>
		///ToUInt16Array 的测试
		///</summary>
		[TestMethod()]
		public void ToUInt16ArrayTest() {
			UnionShort target = new UnionShort(); // TODO: 初始化为适当的值
			ushort[] expected = null; // TODO: 初始化为适当的值
			ushort[] actual;
			actual = target.ToUInt16Array();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("验证此测试方法的正确性。");
		}
	}
}
