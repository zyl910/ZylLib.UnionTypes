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
	/// <summary>
	/// Int union type, size is 4 byte (整数联合体, 大小为4字节). Like `short[2]`, `int[1]`, `float[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
	[Serializable]
#endif
#if (NET20)
#else
	[DataContract]
#endif
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	public struct UnionInt : IUnionInt, IUnionShort {
		/// <summary>int(Int32) 0</summary>
#if (NET20)
#else
		[DataMember]
#endif
		[FieldOffset(0)]
		public int I0;

		/// <summary>uint(UInt32) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public uint UI0;

		/// <summary>float(Single) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public float F0;

		/// <summary>short(Int16) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public short S0;
		/// <summary>short(Int16) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(2)]
		public short S1;

		/// <summary>ushort(UInt16) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ushort US0;
		/// <summary>ushort(UInt16) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(2)]
		public ushort US1;

		/// <summary>byte(Byte) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public byte B0;
		/// <summary>byte(Byte) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(1)]
		public byte B1;
		/// <summary>byte(Byte) 2</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(2)]
		public byte B2;
		/// <summary>byte(Byte) 3</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(3)]
		public byte B3;

		/// <summary>
		/// Construction UnionInt, argument is int type (构造 UnionInt, 参数是 int 类型).
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
		/// Construction UnionInt, argument is uint type (构造 UnionInt, 参数是 uint 类型).
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
		/// Construction UnionInt, argument is float type (构造 UnionInt, 参数是 float 类型).
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
		/// <inheritdoc />
		public override bool Equals(object obj) {
			if (null == obj) return false;
			if (!(obj is UnionInt)) return false;
			UnionInt a = (UnionInt)obj;
			return (I0 == a.I0);
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			return I0.GetHashCode();
		}

		/// <inheritdoc />
		public override string ToString() {
			return I0.ToString();
		}

		#endregion

		#region IUnionShort Member

		/// <inheritdoc />
		public int LoadArray<T>(params T[] src) where T : struct {
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int LoadArrayAt<T>(int offset, int srcOffset, int count, params T[] src) where T : struct {
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int SaveArray<T>(T[] dst) where T : struct {
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int SaveArrayAt<T>(int offset, int dstOffset, int count, T[] dst) where T : struct {
			throw new Exception("The method or operation is not implemented.");
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
