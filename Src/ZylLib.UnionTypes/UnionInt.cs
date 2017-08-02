using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// 4 byte union type. Example `short[2]`, `int[1]`, `float[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
	[Serializable]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	public struct UnionInt {
		/// <summary>int(Int32) 0</summary>
		[FieldOffset(0)]
		public int I0;

		/// <summary>uint(UInt32) 0</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(0)]
		public uint UI0;

		/// <summary>float(Single) 0</summary>
		[FieldOffset(0)]
		public float F0;

		/// <summary>short(Int16) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public short S0;
		/// <summary>short(Int16) 1</summary>
		[NonSerialized]
		[FieldOffset(2)]
		public short S1;

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

		/// <summary>
		/// Create UnionInt, params has int type.
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
		/// Create UnionInt, params has uint type.
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
		/// Create UnionInt, params has float type.
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

		#region Object
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

	}
}
