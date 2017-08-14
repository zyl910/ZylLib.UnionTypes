using System;
using System.Collections.Generic;
using System.Text;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Long union type interface (长整数联合体接口).
	/// </summary>
	/// <revisionHistory>
	///   <revision date="03/08/2017" version="1.0.0.0">Created.</revision>
	/// </revisionHistory>
	public interface IUnionLong : IUnionInt {
		/// <summary>
		/// To Int64 array (转为 Int64 数组).
		/// </summary>
		/// <returns>Return Int64 array (返回 Int64 数组).</returns>
		Int64[] ToInt64Array();

		/// <summary>
		/// To Double array (转为 Double 数组).
		/// </summary>
		/// <returns>Return Double array (返回 Double 数组).</returns>
		Double[] ToDoubleArray();

	}
}
