﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// 2 byte union type. Example `short[1]`
	/// </summary>
	/// 
	/// <namespace>
	/// <summary>
	/// Union types in C# (C#中的联合体类型)
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
		/// Create UnionShort, params has short type.
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
		/// Create UnionShort, params has ushort type.
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

	}
}
