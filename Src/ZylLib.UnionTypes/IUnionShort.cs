using System;
using System.Collections.Generic;
using System.Text;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Short union type interface (短整数联合体接口).
	/// </summary>
	/// <revisionHistory>
	///   <revision date="03/08/2017" version="1.0.0.0">Created.</revision>
	/// </revisionHistory>
	public interface IUnionShort {
		/// <summary>
		/// Load bytes from primitive array (从基元数组中加载字节数据) .
		/// </summary>
		/// <typeparam name="T">Array element type (数组元素类型). Must be primitive type (必须为基元类型).</typeparam>
		/// <param name="src">The source buffer (源缓冲区).</param>
		/// <returns>The total number of bytes load (加载到的字节总数).</returns>
		/// <exception cref="System.ArgumentNullException"><c>src</c> is null.</exception>
		/// <exception cref="System.ArgumentException"><c>src</c> is not an array of primitives.</exception>
		int LoadBytes<T>(params T[] src) where T : struct;

		/// <summary>
		/// Load bytes from primitive array use offset (根据偏移量从基元数组中加载字节数据) .
		/// </summary>
		/// <typeparam name="T">Array element type (数组元素类型). Must be primitive type (必须为基元类型).</typeparam>
		/// <param name="offset">The zero-based byte offset be load (加载位置的字节偏移量，从零开始).</param>
		/// <param name="srcOffset">The zero-based byte offset into src (src 的字节偏移量，从零开始).</param>
		/// <param name="count">The number of bytes to load (要加载的字节数).</param>
		/// <param name="src">The source buffer (源缓冲区).</param>
		/// <returns>The total number of bytes load (加载到的字节总数).</returns>
		/// <exception cref="System.ArgumentNullException"><c>src</c> is null.</exception>
		/// <exception cref="System.ArgumentException"><c>src</c> is not an array of primitives.</exception>
		/// <exception cref="System.ArgumentOutOfRangeException"><c>offset</c>, srcOffset</c>, or <c>count</c> is less than 0.</exception>
		int LoadBytesAt<T>(int offset, int srcOffset, int count, params T[] src) where T : struct;

		/// <summary>
		/// Save bytes to primitive array (保存字节数据到基元数组中) .
		/// </summary>
		/// <typeparam name="T">Array element type (数组元素类型). Must be primitive type (必须为基元类型).</typeparam>
		/// <param name="dst">The destination buffer (目标缓冲区).</param>
		/// <returns>The total number of bytes save (保存到的字节总数).</returns>
		/// <exception cref="System.ArgumentNullException"><c>dst</c> is null.</exception>
		/// <exception cref="System.ArgumentException"><c>dst</c> is not an array of primitives.</exception>
		int SaveBytes<T>(T[] dst) where T : struct;

		/// <summary>
		/// Save bytes to primitive array use offset (根据偏移量保存字节数据到基元数组中) .
		/// </summary>
		/// <typeparam name="T">Array element type (数组元素类型). Must be primitive type (必须为基元类型).</typeparam>
		/// <param name="offset">The zero-based byte offset be save (保存位置的字节偏移量，从零开始).</param>
		/// <param name="dstOffset">The zero-based byte offset into dst (dst 的字节偏移量，从零开始).</param>
		/// <param name="count">The number of bytes to save (要保存的字节数).</param>
		/// <param name="dst">The destination buffer (目标缓冲区).</param>
		/// <returns>The total number of bytes save (保存到的字节总数).</returns>
		/// <exception cref="System.ArgumentNullException"><c>dst</c> is null.</exception>
		/// <exception cref="System.ArgumentException"><c>dst</c> is not an array of primitives.</exception>
		/// <exception cref="System.ArgumentOutOfRangeException"><c>offset</c>, dstOffset</c>, or <c>count</c> is less than 0.</exception>
		int SaveBytesAt<T>(int offset, int dstOffset, int count, T[] dst) where T : struct;

		/// <summary>
		/// To Byte array (转为 Byte 数组).
		/// </summary>
		/// <returns>Return Byte array (返回 Byte 数组).</returns>
		Byte[] ToByteArray();

		/// <summary>
		/// To Int16 array (转为 Int16 数组).
		/// </summary>
		/// <returns>Return Int16 array (返回 Int16 数组).</returns>
		Int16[] ToInt16Array();

	}
}
