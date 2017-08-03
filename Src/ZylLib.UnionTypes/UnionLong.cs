using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Long union type, size is 8 byte (长整数联合体, 大小为8字节). Like `short[4]`, `int[2]`, `long[1]`, `float[2]`, `double[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
	[Serializable]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	public struct UnionLong {
		/// <summary>long(Int64) 0</summary>
		[FieldOffset(0)]
		public long L0;

		/// <summary>ulong(UInt64) 0</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(0)]
		public ulong UL0;

		/// <summary>double(Double) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public double D0;

		/// <summary>int(Int32) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public int I0;
		/// <summary>int(Int32) 1</summary>
		[NonSerialized]
		[FieldOffset(4)]
		public int I1;

		/// <summary>uint(UInt32) 0</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(0)]
		public uint UI0;
		/// <summary>uint(UInt32) 1</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(4)]
		public uint UI1;

		/// <summary>float(Single) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public float F0;
		/// <summary>float(Single) 0</summary>
		[NonSerialized]
		[FieldOffset(4)]
		public float F1;

		/// <summary>short(Int16) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public short S0;
		/// <summary>short(Int16) 1</summary>
		[NonSerialized]
		[FieldOffset(2)]
		public short S1;
		/// <summary>short(Int16) 2</summary>
		[NonSerialized]
		[FieldOffset(4)]
		public short S2;
		/// <summary>short(Int16) 3</summary>
		[NonSerialized]
		[FieldOffset(6)]
		public short S3;

		/// <summary>ushort(UInt16) 0</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(0)]
		public ushort US0;
		/// <summary>ushort(UInt16) 1</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(2)]
		public ushort US1;
		/// <summary>ushort(UInt16) 2</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(4)]
		public ushort US2;
		/// <summary>ushort(UInt16) 3</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(6)]
		public ushort US3;

		/// <summary>byte(Byte) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public byte B0;
		/// <summary>byte(Byte) 1</summary>
		[NonSerialized]
		[FieldOffset(1)]
		public byte B1;
		/// <summary>byte(Byte) 2</summary>
		[NonSerialized]
		[FieldOffset(2)]
		public byte B2;
		/// <summary>byte(Byte) 3</summary>
		[NonSerialized]
		[FieldOffset(3)]
		public byte B3;
		/// <summary>byte(Byte) 4</summary>
		[NonSerialized]
		[FieldOffset(4)]
		public byte B4;
		/// <summary>byte(Byte) 5</summary>
		[NonSerialized]
		[FieldOffset(5)]
		public byte B5;
		/// <summary>byte(Byte) 6</summary>
		[NonSerialized]
		[FieldOffset(6)]
		public byte B6;
		/// <summary>byte(Byte) 7</summary>
		[NonSerialized]
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

		#region Object
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

	}
}
