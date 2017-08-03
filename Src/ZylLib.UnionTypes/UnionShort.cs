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
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
	[Serializable]
#endif
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	public struct UnionShort : IUnionShort {
		/// <summary>short(Int16) 0</summary>
		[FieldOffset(0)]
		public short S0;

		/// <summary>ushort(UInt16) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ushort US0;

		/// <summary>byte(Byte) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[FieldOffset(0)]
		public byte B0;
		/// <summary>byte(Byte) 1</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
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

		#region Method
		/// <summary>
		/// To SByte array (转为 SByte 数组).
		/// </summary>
		/// <returns>Return SByte array (返回 SByte 数组).</returns>
		[CLSCompliant(false)]
		public SByte[] ToSByteArray() {
			unchecked {
				return new SByte[] { (SByte)B0, (SByte)B1 };
			}
		}

		/// <summary>
		/// To UInt16 array (转为 UInt16 数组).
		/// </summary>
		/// <returns>Return UInt16 array (返回 UInt16 数组).</returns>
		[CLSCompliant(false)]
		public UInt16[] ToUInt16Array() {
			return new UInt16[] { US0 };
		}

		#endregion

		#region Object Member
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
			return new Byte[] { B0, B1 };
		}

		/// <inheritdoc />
		public short[] ToInt16Array() {
			return new Int16[] { S0 };
		}

		#endregion

	}
}
