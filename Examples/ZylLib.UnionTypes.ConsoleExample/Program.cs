using System;
using System.Collections.Generic;
using System.Text;
using ZylLib.UnionTypes;

namespace ZylLib.UnionTypes.ConsoleExample {
	class Program {
		static void Main(string[] args) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ZylLib.UnionTypes.ConsoleExample");
			sb.AppendLine(string.Format("IsLittleEndian: {0}", BitConverter.IsLittleEndian));
			sb.AppendLine();
			TestShort(sb);
			TestInt(sb);
			TestLong(sb);
			// show.
			Console.WriteLine(sb.ToString());
		}

		/// <summary>
		/// Test UnionShort .
		/// </summary>
		/// <param name="sb">String buffer.</param>
		public static void TestShort(StringBuilder sb) {
			sb.AppendLine("[UnionShort]");
			// ctor.
			UnionShort v = new UnionShort(0x8765);
			sb.AppendLine(string.Format("S: {0} // HEX {0:X4}", v.S0));
			sb.AppendLine(string.Format("US: {0} // HEX {0:X4}", v.US0));
			sb.AppendLine(string.Format("B(HEX): {0:X2} {1:X2}", v.B0, v.B1));
			sb.AppendLine(string.Format("Equals(null): {0}", v.Equals(null)));
			sb.AppendLine(string.Format("GetHashCode: {0}", v.GetHashCode()));
			sb.AppendLine(string.Format("ToString: {0}", v.ToString()));
			// done.
			sb.AppendLine();
		}

		/// <summary>
		/// Test UnionInt .
		/// </summary>
		/// <param name="sb">String buffer.</param>
		public static void TestInt(StringBuilder sb) {
			sb.AppendLine("[TestInt]");
			// ctor.
			UnionInt v = new UnionInt((float)-Math.PI);
			sb.AppendLine(string.Format("F: {0}", v.F0));
			sb.AppendLine(string.Format("I: {0} // HEX {0:X8}", v.I0));
			sb.AppendLine(string.Format("UI: {0} // HEX {0:X8}", v.UI0));
			sb.AppendLine(string.Format("S: {0}, {1} // HEX {0:X4} {1:X4}", v.S0, v.S1));
			sb.AppendLine(string.Format("B(HEX): {0:X2} {1:X2} {2:X2} {3:X2}", v.B0, v.B1, v.B2, v.B3));
			sb.AppendLine(string.Format("Equals(null): {0}", v.Equals(null)));
			sb.AppendLine(string.Format("GetHashCode: {0}", v.GetHashCode()));
			sb.AppendLine(string.Format("ToString: {0}", v.ToString()));
			// done.
			sb.AppendLine();
		}

		/// <summary>
		/// Test UnionLong .
		/// </summary>
		/// <param name="sb">String buffer.</param>
		public static void TestLong(StringBuilder sb) {
			sb.AppendLine("[TestLong]");
			// ctor.
			UnionLong v = new UnionLong(-Math.PI);
			sb.AppendLine(string.Format("D: {0}", v.D0));
			sb.AppendLine(string.Format("L: {0} // HEX {0:X16}", v.L0));
			sb.AppendLine(string.Format("UL: {0} // HEX {0:X16}", v.UL0));
			sb.AppendLine(string.Format("F: {0}, {1}", v.F0, v.F1));
			sb.AppendLine(string.Format("I: {0}, {1} // HEX {0:X8} {1:X8}", v.I0, v.I1));
			sb.AppendLine(string.Format("S: {0}, {1}, {2}, {3} // HEX {0:X4} {1:X4} {2:X4} {3:X4}", v.S0, v.S1, v.S2, v.S3));
			sb.AppendLine(string.Format("B(HEX): {0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2}", v.B0, v.B1, v.B2, v.B3, v.B4, v.B5, v.B6, v.B7));
			sb.AppendLine(string.Format("Equals(null): {0}", v.Equals(null)));
			sb.AppendLine(string.Format("GetHashCode: {0}", v.GetHashCode()));
			sb.AppendLine(string.Format("ToString: {0}", v.ToString()));
			// done.
			sb.AppendLine();
		}

	}
}
