using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
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
			sb.AppendLine("[TestShort]");
			// ctor.
			UnionShort v = new UnionShort(0x8765);
			sb.AppendLine(string.Format("S: {0} // HEX {0:X4}", v.S0));
			sb.AppendLine(string.Format("US: {0} // HEX {0:X4}", v.US0));
			sb.AppendLine(string.Format("B(HEX): {0:X2} {1:X2}", v.B0, v.B1));
			sb.AppendLine(string.Format("Equals(null): {0}", v.Equals(null)));
			sb.AppendLine(string.Format("GetHashCode: {0}", v.GetHashCode()));
			sb.AppendLine(string.Format("ToString: {0}", v.ToString()));
			sb.AppendLine(StrByArray("ToSByteArray", v.ToSByteArray()));
			sb.AppendLine(StrByArray("ToByteArray", v.ToByteArray()));
			sb.AppendLine(StrByArray("ToUInt16Array", v.ToUInt16Array()));
			sb.AppendLine(StrByArray("ToInt16Array", v.ToInt16Array()));
			// XmlSerializer
			XmlSerializer serializer = new XmlSerializer(v.GetType());
			using (StringWriter sw = new StringWriter(sb)) {
				serializer.Serialize(sw, v);
			}
			sb.AppendLine();
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
			sb.AppendLine(StrByArray("ToByteArray", v.ToByteArray()));
			sb.AppendLine(StrByArray("ToInt16Array", v.ToInt16Array()));
			sb.AppendLine(StrByArray("ToUInt32Array", v.ToUInt32Array()));
			sb.AppendLine(StrByArray("ToInt32Array", v.ToInt32Array()));
			sb.AppendLine(StrByArray("ToSingleArray", v.ToSingleArray()));
			// XmlSerializer
			XmlSerializer serializer = new XmlSerializer(v.GetType());
			using (StringWriter sw = new StringWriter(sb)) {
				serializer.Serialize(sw, v);
			}
			sb.AppendLine();
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
			sb.AppendLine(StrByArray("ToByteArray", v.ToByteArray()));
			sb.AppendLine(StrByArray("ToInt16Array", v.ToInt16Array()));
			sb.AppendLine(StrByArray("ToInt32Array", v.ToInt32Array()));
			sb.AppendLine(StrByArray("ToSingleArray", v.ToSingleArray()));
			sb.AppendLine(StrByArray("ToUInt64Array", v.ToUInt64Array()));
			sb.AppendLine(StrByArray("ToInt64Array", v.ToInt64Array()));
			sb.AppendLine(StrByArray("ToDoubleArray", v.ToDoubleArray()));
			// XmlSerializer
			XmlSerializer serializer = new XmlSerializer(v.GetType());
			using (StringWriter sw = new StringWriter(sb)) {
				serializer.Serialize(sw, v);
			}
			sb.AppendLine();
			// done.
			sb.AppendLine();
		}

		/// <summary>
		/// Get string by array(取得数组的字符串说明).
		/// </summary>
		/// <typeparam name="T">Array element type (数组元素类型).</typeparam>
		/// <param name="name">Name (名称).</param>
		/// <param name="arr">Array (数组).</param>
		/// <returns>Return string by array (返回字符串说明).</returns>
		private static string StrByArray<T>(string name, T[] arr) {
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}: ", name);
			if (null == arr) {
				sb.Append("null");
			}
			else {
				sb.Append(arr);
				sb.AppendFormat(", Length={0}", arr.Length);
				sb.Append(", Data=");
				foreach(T n in arr) {
					sb.AppendFormat(" {0}", n);
				}
			}
			return sb.ToString();
		}

	}
}
