using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Short union type, size is 2 byte (短整数联合体, 大小为2字节). Like `short[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
	/// 
	/// <namespace>
	/// <summary>
	/// Union types in C# (C#的联合体类型)
	/// </summary>
	/// </namespace>
	[Serializable]
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	public struct UnionShort {
		/// <summary>short(Int16) 0</summary>
		[FieldOffset(0)]
		public short S0;

		/// <summary>ushort(UInt16) 0</summary>
		[CLSCompliant(false)]
		[NonSerialized]
		[FieldOffset(0)]
		public ushort US0;

		/// <summary>byte(Byte) 0</summary>
		[NonSerialized]
		[FieldOffset(0)]
		public byte B0;
		/// <summary>byte(Byte) 1</summary>
		[NonSerialized]
		[FieldOffset(1)]
		public byte B1;

		/// <summary>
		/// Construction UnionShort, argument is short type (构造 UnionShort, 参数是 short 类型).
		/// </summary>
		/// <param name="v">Value</param>
		public UnionShort(short v) {
			US0 = 0;
			B0 = 0;
			B1 = 0;
			// set.
			S0 = v;
		}

		/// <summary>
		/// Construction UnionShort, argument is ushort type (构造 UnionShort, 参数是 ushort 类型).
		/// </summary>
		/// <param name="v">Value</param>
		[CLSCompliant(false)]
		public UnionShort(ushort v) {
			S0 = 0;
			B0 = 0;
			B1 = 0;
			// set.
			US0 = v;
		}

		#region Object
		/// <inheritdoc />
		public override bool Equals(object obj) {
			if (null == obj) return false;
			if (!(obj is UnionShort)) return false;
			UnionShort a = (UnionShort)obj;
			return (S0 == a.S0);
		}

		/// <inheritdoc />
		public override int GetHashCode() {
			return S0.GetHashCode();
		}

		/// <inheritdoc />
		public override string ToString() {
			return S0.ToString();
		}

		#endregion

	}
}
