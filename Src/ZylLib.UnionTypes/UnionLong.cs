using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Long union type, size is 8 byte (长整数联合体, 大小为8字节). Like `short[4]`, `int[2]`, `long[1]`, `float[2]`, `double[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
	[Serializable]
#endif
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	public struct UnionLong : IUnionLong, IUnionInt, IUnionShort {
		/// <summary>long(Int64) 0</summary>
		[FieldOffset(0)]
		public long L0;

		/// <summary>ulong(UInt64) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ulong UL0;

		/// <summary>double(Double) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public double D0;

		/// <summary>int(Int32) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public int I0;
		/// <summary>int(Int32) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(4)]
		public int I1;

		/// <summary>uint(UInt32) 0</summary>
		[CLSCompliant(false)]
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public uint UI0;
		/// <summary>uint(UInt32) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(4)]
		public uint UI1;

		/// <summary>float(Single) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(0)]
		public float F0;
		/// <summary>float(Single) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(4)]
		public float F1;

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
		/// <summary>short(Int16) 2</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(4)]
		public short S2;
		/// <summary>short(Int16) 3</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(6)]
		public short S3;

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
		/// <summary>ushort(UInt16) 2</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(4)]
		public ushort US2;
		/// <summary>ushort(UInt16) 3</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(6)]
		public ushort US3;

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
		/// <summary>byte(Byte) 4</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(4)]
		public byte B4;
		/// <summary>byte(Byte) 5</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(5)]
		public byte B5;
		/// <summary>byte(Byte) 6</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(6)]
		public byte B6;
		/// <summary>byte(Byte) 7</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[FieldOffset(7)]
		public byte B7;

		/// <summary>
		/// Create UnionLong, argument is long type.
		/// </summary>
		/// <param name="v">Value</param>
		public UnionLong(long v) {
			UL0 = 0;
			D0 = 0;
			I0 = 0;
			I1 = 0;
			UI0 = 0;
			UI1 = 0;
			F0 = 0;
			F1 = 0;
			S0 = 0;
			S1 = 0;
			S2 = 0;
			S3 = 0;
			US0 = 0;
			US1 = 0;
			US2 = 0;
			US3 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			B4 = 0;
			B5 = 0;
			B6 = 0;
			B7 = 0;
			// set.
			L0 = v;
		}

		/// <summary>
		/// Create UnionLong, argument is ulong type.
		/// </summary>
		/// <param name="v">Value</param>
		[CLSCompliant(false)]
		public UnionLong(ulong v) {
			L0 = 0;
			D0 = 0;
			I0 = 0;
			I1 = 0;
			UI0 = 0;
			UI1 = 0;
			F0 = 0;
			F1 = 0;
			S0 = 0;
			S1 = 0;
			S2 = 0;
			S3 = 0;
			US0 = 0;
			US1 = 0;
			US2 = 0;
			US3 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			B4 = 0;
			B5 = 0;
			B6 = 0;
			B7 = 0;
			// set.
			UL0 = v;
		}

		/// <summary>
		/// Create UnionLong, argument is double type.
		/// </summary>
		/// <param name="v">Value</param>
		public UnionLong(double v) {
			L0 = 0;
			UL0 = 0;
			I0 = 0;
			I1 = 0;
			UI0 = 0;
			UI1 = 0;
			F0 = 0;
			F1 = 0;
			S0 = 0;
			S1 = 0;
			S2 = 0;
			S3 = 0;
			US0 = 0;
			US1 = 0;
			US2 = 0;
			US3 = 0;
			B0 = 0;
			B1 = 0;
			B2 = 0;
			B3 = 0;
			B4 = 0;
			B5 = 0;
			B6 = 0;
			B7 = 0;
			// set.
			D0 = v;
		}

		#region Method
		/// <summary>
		/// To SByte array (转为 SByte 数组).
		/// </summary>
		/// <returns>Return SByte array (返回 SByte 数组).</returns>
		[CLSCompliant(false)]
		public SByte[] ToSByteArray() {
			unchecked {
				return new SByte[] { (SByte)B0, (SByte)B1, (SByte)B2, (SByte)B3, (SByte)B4, (SByte)B5, (SByte)B6, (SByte)B7 };
			}
		}

		/// <summary>
		/// To UInt16 array (转为 UInt16 数组).
		/// </summary>
		/// <returns>Return UInt16 array (返回 UInt16 数组).</returns>
		[CLSCompliant(false)]
		public UInt16[] ToUInt16Array() {
			return new UInt16[] { US0, US1, US2, US3 };
		}

		/// <summary>
		/// To UInt32 array (转为 UInt32 数组).
		/// </summary>
		/// <returns>Return UInt32 array (返回 UInt32 数组).</returns>
		[CLSCompliant(false)]
		public UInt32[] ToUInt32Array() {
			return new UInt32[] { UI0, UI1 };
		}

		/// <summary>
		/// To UInt64 array (转为 UInt64 数组).
		/// </summary>
		/// <returns>Return UInt64 array (返回 UInt64 数组).</returns>
		[CLSCompliant(false)]
		public UInt64[] ToUInt64Array() {
			return new UInt64[] { UL0 };
		}

		#endregion

		#region Object Member
		/// <inheritdoc />
		public override bool Equals(object obj) {
			if (null == obj) return false;
			if (!(obj is UnionLong)) return false;
			UnionLong a = (UnionLong)obj;
			return (L0 == a.L0);
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			return L0.GetHashCode();
		}

		/// <inheritdoc />
		public override string ToString() {
			return L0.ToString();
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
			return new Byte[] { B0, B1, B2, B3, B4, B5, B6, B7 };
		}

		/// <inheritdoc />
		public short[] ToInt16Array() {
			return new Int16[] { S0, S1, S2, S3 };
		}

		#endregion

		#region IUnionInt Member

		/// <inheritdoc />
		public int[] ToInt32Array() {
			return new Int32[] { I0, I1 };
		}

		/// <inheritdoc />
		public float[] ToSingleArray() {
			return new Single[] { F0, F1 };
		}

		#endregion

		#region IUnionLong Member

		/// <inheritdoc />
		public long[] ToInt64Array() {
			return new Int64[] { L0 };
		}

		/// <inheritdoc />
		public double[] ToDoubleArray() {
			return new Double[] { D0 };
		}

		#endregion

	}
}
