using System;
using ZylLib.UnionTypes;
#if NUNIT
using NUnit.Framework;
using TestClassAttribute = NUnit.Framework.TestFixtureAttribute;
using TestMethodAttribute = NUnit.Framework.TestAttribute;
#elif XUNIT
using Xunit;
using TestClassAttribute = Xunit.FactAttribute;
using TestMethodAttribute = Newtonsoft.Json.Tests.XUnitAssert;
#elif NETFX_CORE
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace ZylLib.UnionTypes.Test
{
    
    
    /// <summary>
    ///这是 UnionShortTest 的测试类，旨在
    ///包含所有 UnionShortTest 单元测试
    ///</summary>
	[TestClass()]
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
			target.B0 = 0x01;
			target.B1 = 0x23;
			short expectedint = (BitConverter.IsLittleEndian) ? (short)0x2301 : (short)0x0123;
			UnionShort expected = new UnionShort(expectedint);
			Assert.AreEqual(false, target.Equals(null));
			Assert.AreEqual(true, target.Equals(expected));
			Assert.AreEqual(expected, target);
		}

		/// <summary>
		///LoadBytes 的测试
		///</summary>
		[TestMethod()]
		public void LoadBytesTest() {
			UnionShort target = new UnionShort();
			target.LoadBytes<byte>(0x01, 0x23);
			short expectedint = (BitConverter.IsLittleEndian) ? (short)0x2301 : (short)0x0123;
			UnionShort expected = new UnionShort(expectedint);
			Assert.AreEqual(expected, target);
		}

		/// <summary>
		///LoadBytesAt 的测试
		///</summary>
		[TestMethod()]
		public void LoadBytesAtTest() {
			UnionShort target = new UnionShort();
			target.LoadBytesAt<byte>(0, 1, 2, 0x01);
			short expectedint = (BitConverter.IsLittleEndian) ? (short)0x0100 : (short)0x0001;
			UnionShort expected = new UnionShort(expectedint);
			Assert.AreEqual(expected, target);
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
