using System;
using System.Collections.Generic;
using System.Text;

namespace ZylLib.UnionTypes {
	/// <summary>
	/// Int union type interface (整数联合体接口).
	/// </summary>
	/// <revisionHistory>
	///   <revision date="03/08/2017" version="1.0.0.0">Created.</revision>
	/// </revisionHistory>
	public interface IUnionInt : IUnionShort {
		/// <summary>
		/// To Int32 array (转为 Int32 数组).
		/// </summary>
		/// <returns>Return Int32 array (返回 Int32 数组).</returns>
		Int32[] ToInt32Array();

		/// <summary>
		/// To Single array (转为 Single 数组).
		/// </summary>
		/// <returns>Return Single array (返回 Single 数组).</returns>
		Single[] ToSingleArray();

	}
}
