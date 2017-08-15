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
	/// Short union type, size is 2 byte (短整数联合体, 大小为2字节). Like `short[1]` .
	/// </summary>
	/// <remarks>
	/// In multithreaded environments, It is recommended to Thread.MemoryBarrier before read (在多线程环境下，建议在读取之前调用Thread.MemoryBarrier).
	/// </remarks>
	/// <threadsafety static="true" instance="false"/>
	/// <revisionHistory>
	///   <revision date="02/08/2017" version="1.0.0.0">Created.</revision>
	/// </revisionHistory>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
	[Serializable]
#endif
#if (NET20)
#else
	[DataContract]
#endif
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	public struct UnionShort : IUnionShort {
		/// <summary>short(Int16) 0</summary>
#if (NET20)
#else
		[DataMember]
#endif
		[FieldOffset(0)]
		public short S0;

		/// <summary>ushort(UInt16) 0</summary>
#if (PORTABLE || NETSTANDARD || NETFX_CORE || SILVERLIGHT || XBOX || WindowsCE)
#else
		[NonSerialized]
#endif
		[XmlIgnore]
#if (NET20)	// No need, because DataContract know XmlIgnoreAttribute (不需要, 因为 DataContract 认识 XmlIgnoreAttribute).
#else
		[IgnoreDataMember]
#endif
		[CLSCompliant(false)]
		[FieldOffset(0)]
		public ushort US0;

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
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int LoadBytesAt<T>(int offset, int srcOffset, int count, params T[] src) where T : struct {
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int SaveBytes<T>(T[] dst) where T : struct {
			throw new Exception("The method or operation is not implemented.");
		}

		/// <inheritdoc />
		public int SaveBytesAt<T>(int offset, int dstOffset, int count, T[] dst) where T : struct {
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
