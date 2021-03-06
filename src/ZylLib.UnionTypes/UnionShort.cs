﻿using System;
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
	/// Short union type, size is 2 byte (短整数联合体, 大小为2字节). Like `short[1]` .
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
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	public struct UnionShort : IUnionShort {
		/// <summary>The bytes size of this instance (此实例的字节大小).</summary>
		public const int BytesSize = 2;

		/// <summary>short(Int16) 0</summary>
#if (NET20 || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6)
#else
		[DataMember]
#endif
		[FieldOffset(0)]
		public short S0;

		/// <summary>ushort(UInt16) 0</summary>
#if (PORTABLE || NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ushort US0;

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

		/// <summary>
		/// Initializes a new instance of the UnionShort class using a short value (使用 short 值初始化 UnionShort 类的新实例).
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
		/// Initializes a new instance of the UnionShort class using a ushort value (使用 ushort 值初始化 UnionShort 类的新实例).
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

		#region Property

		#endregion

		#region Object Member
		/// <summary>
		/// Determines whether the specified object is equal to the current object (确定指定的对象是否等于当前对象).
		/// </summary>
		/// <param name="obj">The object to compare with the current object.</param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public override bool Equals(object obj) {
			if (null == obj) return false;
			if (!(obj is UnionShort)) return false;
			UnionShort a = (UnionShort)obj;
			return (S0 == a.S0);
		}

		/// <summary>
		/// Returns the hash code for the current object (返回当前对象的哈希代码).
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode() {
			return S0.GetHashCode();
		}

		/// <summary>
		/// Returns a string that represents the current object (返回表示当前对象的字符串).
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString() {
			return S0.ToString();
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
				short[] buf = new short[1] { S0 };
				Buffer.BlockCopy(src, srcOffset, buf, offset, count);
				S0 = buf[0];
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
				short[] buf = new short[1] { S0 };
				Buffer.BlockCopy(buf, offset, dst, dstOffset, count);
			}
			return count;
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
