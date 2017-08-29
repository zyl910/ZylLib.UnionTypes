using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
#if (NET20)
#else
// .NET 3.0+: System.Runtime.Serialization.dll .
using System.Runtime.Serialization;
#endif

namespace ZylLib.UnionTypes {
#if (NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6)
	using XmlIgnoreAttribute = NotSupportedXmlIgnoreAttribute;
#else
#endif

	/// <summary>
	/// Int union type, size is 4 byte (整数联合体, 大小为4字节). Like `short[2]`, `int[1]`, `float[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
	/// <threadsafety static="true" instance="false"/>
	/// <revisionHistory>
	///   <revision date="02/08/2017" version="1.0.0.0">Created.</revision>
	/// </revisionHistory>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
	[Serializable]
#endif
#if (NET20 || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6)
#else
	[DataContract]
#endif
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	public struct UnionInt : IUnionInt, IUnionShort {
		/// <summary>The bytes size of this instance (此实例的字节大小).</summary>
		public const int BytesSize = 4;

		/// <summary>int(Int32) 0</summary>
#if (NET20 || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6)
#else
		[DataMember]
#endif
		[FieldOffset(0)]
		public int I0;

		/// <summary>uint(UInt32) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public uint UI0;

		/// <summary>float(Single) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public float F0;

		/// <summary>short(Int16) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public short S0;
		/// <summary>short(Int16) 1</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(2)]
		public short S1;

		/// <summary>ushort(UInt16) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ushort US0;
		/// <summary>ushort(UInt16) 1</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(2)]
		public ushort US1;

		/// <summary>byte(Byte) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public byte B0;
		/// <summary>byte(Byte) 1</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(1)]
		public byte B1;
		/// <summary>byte(Byte) 2</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(2)]
		public byte B2;
		/// <summary>byte(Byte) 3</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(3)]
		public byte B3;

		/// <summary>
		/// Initializes a new instance of the UnionInt class using a int value (使用 int 值初始化 UnionInt 类的新实例).
		/// </summary>
		/// <param name="v">Value</param>
		public UnionInt(int v) {
			UI0 = 0;
			F0 = 0;
			S0 = 0;
			S1 = 0;
			US0 = 0;
			US1 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			// set.
			I0 = v;
		}

		/// <summary>
		/// Initializes a new instance of the UnionInt class using a uint value (使用 uint 值初始化 UnionInt 类的新实例).
		/// </summary>
		/// <param name="v">Value</param>
		[CLSCompliant(false)]
		public UnionInt(uint v) {
			I0 = 0;
			F0 = 0;
			S0 = 0;
			S1 = 0;
			US0 = 0;
			US1 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			// set.
			UI0 = v;
		}

		/// <summary>
		/// Initializes a new instance of the UnionInt class using a float value (使用 float 值初始化 UnionInt 类的新实例).
		/// </summary>
		/// <param name="v">Value</param>
		public UnionInt(float v) {
			I0 = 0;
			UI0 = 0;
			S0 = 0;
			S1 = 0;
			US0 = 0;
			US1 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			// set.
			F0 = v;
		}

		#region Method
		/// <summary>
		/// To SByte array (转为 SByte 数组).
		/// </summary>
		/// <returns>Return SByte array (返回 SByte 数组).</returns>
		[CLSCompliant(false)]
		public SByte[] ToSByteArray() {
			unchecked {
				return new SByte[] { (SByte)B0, (SByte)B1, (SByte)B2, (SByte)B3 };
			}
		}

		/// <summary>
		/// To UInt16 array (转为 UInt16 数组).
		/// </summary>
		/// <returns>Return UInt16 array (返回 UInt16 数组).</returns>
		[CLSCompliant(false)]
		public UInt16[] ToUInt16Array() {
			return new UInt16[] { US0, US1 };
		}

		/// <summary>
		/// To UInt32 array (转为 UInt32 数组).
		/// </summary>
		/// <returns>Return UInt32 array (返回 UInt32 数组).</returns>
		[CLSCompliant(false)]
		public UInt32[] ToUInt32Array() {
			return new UInt32[] { UI0 };
		}

		#endregion

		#region Object Member
		/// <summary>
		/// Determines whether the specified object is equal to the current object (确定指定的对象是否等于当前对象).
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public override bool Equals(object obj) {
			if (null == obj) return false;
			if (!(obj is UnionInt)) return false;
			UnionInt a = (UnionInt)obj;
			return (I0 == a.I0);
		}

		/// <summary>
		/// Returns the hash code for the current object (返回当前对象的哈希代码).
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode() {
			return I0.GetHashCode();
		}

		/// <summary>
		/// Returns a string that represents the current object (返回表示当前对象的字符串).
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString() {
			return I0.ToString();
		}

		#endregion

		#region IUnionShort Member

		/// <inheritdoc />
		public int LoadBytes<T>(params T[] src) where T : struct {
			return LoadBytesAt(0, 0, BytesSize, src);
		}

		/// <inheritdoc />
		public int LoadBytesAt<T>(int offset, int srcOffset, int count, params T[] src) where T : struct {
			if (null == src) throw new ArgumentNullException("src", "src is null!");
			if (offset < 0) throw new ArgumentException("offset is less than 0!", "offset");
			if (srcOffset < 0) throw new ArgumentException("srcOffset is less than 0!", "srcOffset");
			if (count < 0) throw new ArgumentException("count is less than 0!", "count");
			if ((offset + count) > BytesSize) count = BytesSize - offset;
			if (count <= 0) return count;
			int srcSize = Buffer.ByteLength(src);
			if ((srcOffset + count) > srcSize) count = srcSize - srcOffset;
			if (count > 0) {
				int[] buf = new int[1] { I0 };
				Buffer.BlockCopy(src, srcOffset, buf, offset, count);
				I0 = buf[0];
			}
			return count;
		}

		/// <inheritdoc />
		public int SaveBytes<T>(T[] dst) where T : struct {
			return SaveBytesAt(0, 0, BytesSize, dst);
		}

		/// <inheritdoc />
		public int SaveBytesAt<T>(int offset, int dstOffset, int count, T[] dst) where T : struct {
			if (null == dst) throw new ArgumentNullException("dst", "dst is null!");
			if (offset < 0) throw new ArgumentException("offset is less than 0!", "offset");
			if (dstOffset < 0) throw new ArgumentException("dstOffset is less than 0!", "dstOffset");
			if (count < 0) throw new ArgumentException("count is less than 0!", "count");
			if ((offset + count) > BytesSize) count = BytesSize - offset;
			if (count <= 0) return count;
			int dstSize = Buffer.ByteLength(dst);
			if ((dstOffset + count) > dstSize) count = dstSize - dstOffset;
			if (count > 0) {
				int[] buf = new int[1] { I0 };
				Buffer.BlockCopy(buf, offset, dst, dstOffset, count);
			}
			return count;
		}

		/// <inheritdoc />
		public byte[] ToByteArray() {
			return new Byte[] { B0, B1, B2, B3 };
		}

		/// <inheritdoc />
		public short[] ToInt16Array() {
			return new Int16[] { S0, S1 };
		}

		#endregion

		#region IUnionInt Member

		/// <inheritdoc />
		public int[] ToInt32Array() {
			return new Int32[] { I0 };
		}

		/// <inheritdoc />
		public float[] ToSingleArray() {
			return new Single[] { F0 };
		}

		#endregion

	}
}
