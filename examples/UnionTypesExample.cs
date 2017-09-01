using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using ZylLib.UnionTypes;
#if (NET20 || NET30)
#else
// .NET 3.5: System.Runtime.Serialization.dll .
// Silverlight 3: System.ServiceModel.Web.dll.
using System.Runtime.Serialization.Json;
#endif

namespace ZylLib.UnionTypes {
	/// <summary>
	/// UnionTypes example (ZylLib.UnionTypes 的范例代码).
	/// </summary>
	public static class UnionTypesExample {

		/// <summary>
		/// Example output (范例输出).
		/// </summary>
		/// <param name="sb">String buffer.</param>
		public static void Output(StringBuilder sb) {
			sb.AppendLine(string.Format("AssemblyQualifiedName: {0}", typeof(UnionTypesExample).AssemblyQualifiedName));
			sb.AppendLine(string.Format("Environment.AssemblyQualifiedName: {0}", typeof(Environment).AssemblyQualifiedName));
			sb.AppendLine(string.Format("IsLittleEndian: {0}", BitConverter.IsLittleEndian));
			sb.AppendLine();
			TestShort(sb);
			TestInt(sb);
			TestLong(sb);
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
			// DataContractJsonSerializer .
#if (NET20 || NET30)
#else
			string jsonstr = DataContractJson(v);
			sb.AppendLine(string.Format("DataContractJson: {0}", jsonstr));
			if (!string.IsNullOrEmpty(jsonstr)) {
				UnionLong v2 = DataContractJsonDeserialize<UnionLong>(jsonstr);
				sb.AppendLine(StrByArray("DataContractJsonDeserialize", v2.ToByteArray()));
			}
#endif
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
			// DataContractJsonSerializer .
#if (NET20 || NET30)
#else
			string jsonstr = DataContractJson(v);
			sb.AppendLine(string.Format("DataContractJson: {0}", jsonstr));
			if (!string.IsNullOrEmpty(jsonstr)) {
				UnionLong v2 = DataContractJsonDeserialize<UnionLong>(jsonstr);
				sb.AppendLine(StrByArray("DataContractJsonDeserialize", v2.ToByteArray()));
			}
#endif
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
			// LoadBytes.
			if (true) {
				v.LoadBytesAt(5, 0, 2, (byte)0x55, (byte)0xAA);
				short[] buf = new short[2];
				v.SaveBytesAt(4, 0, 4, buf);
				sb.AppendLine(string.Format("LoadBytesAt D: {0}", v.D0));
				sb.AppendLine(string.Format("LoadBytesAt L: {0} // HEX {0:X16}", v.L0));
				sb.AppendLine(string.Format("LoadBytesAt B(HEX): {0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2}", v.B0, v.B1, v.B2, v.B3, v.B4, v.B5, v.B6, v.B7));
				sb.AppendLine(StrByArray("SaveBytesAt", buf));
			}
			// XmlSerializer
			XmlSerializer serializer = new XmlSerializer(v.GetType());
			using (StringWriter sw = new StringWriter(sb)) {
				serializer.Serialize(sw, v);
			}
			sb.AppendLine();
			// DataContractJsonSerializer .
#if (NET20 || NET30)
#else
			string jsonstr = DataContractJson(v);
			sb.AppendLine(string.Format("DataContractJson: {0}", jsonstr));
			if (!string.IsNullOrEmpty(jsonstr)) {
				UnionLong v2 = DataContractJsonDeserialize<UnionLong>(jsonstr);
				sb.AppendLine(StrByArray("DataContractJsonDeserialize", v2.ToByteArray()));
			}
#endif
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
			} else {
				sb.Append(arr);
				sb.AppendFormat(", Length={0}", arr.Length);
				sb.Append(", Data=");
				foreach (T n in arr) {
					sb.AppendFormat(" {0}", n);
				}
			}
			return sb.ToString();
		}

		/// <summary>
		/// DataContract json serialize (使用DataContract将对象序列化为JSON).
		/// </summary>
		/// <typeparam name="T">Type .</typeparam>
		/// <param name="obj">Object .</param>
		/// <returns>Return json string (返回JSON字符串).</returns>
		private static string DataContractJson<T>(T obj) {
			string rt = null;
			if (null == obj) return rt;
#if (NET20 || NET30)
#else
			using (MemoryStream ms = new MemoryStream()) {
				DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
				ser.WriteObject(ms, obj);
				byte[] json = ms.ToArray();
				ms.Flush();
#if (NETCOREAPP1_0 || NETCOREAPP1_1)
				// Need .NET Core/STANDARD 2.0 +
#else
				ms.Close();
#endif
				rt = Encoding.UTF8.GetString(json, 0, json.Length);
			}
#endif
				return rt;
		}

		/// <summary>
		/// DataContract json deserialize (使用DataContract将JSON反序列化为对象).
		/// </summary>
		/// <typeparam name="T">Type .</typeparam>
		/// <param name="jsonString"></param>
		/// <returns>Return object (返回反序列化后的对象).</returns>
		public static T DataContractJsonDeserialize<T>(string jsonString) {
			T rt = default(T);
#if (NET20 || NET30)
#else
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
			using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString))) {
				rt = (T)ser.ReadObject(ms);
				ms.Flush();
#if (NETCOREAPP1_0 || NETCOREAPP1_1)
				// Need .NET Core/STANDARD 2.0 +
#else
				ms.Close();
#endif
			}
#endif
			return rt;
		}
	}
}