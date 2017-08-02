using System;
using System.Collections.Generic;
using System.Text;

namespace ZylLib.UnionTypes.ConsoleExample {
	class Program {
		static void Main(string[] args) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ZylLib.UnionTypes.ConsoleExample");
			sb.AppendLine(string.Format("IsLittleEndian: {0}", BitConverter.IsLittleEndian));
			sb.AppendLine();
			TestShort(sb);
			TestInt(sb);
			// show.
			Console.WriteLine(sb.ToString());
		}

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

	}
}
