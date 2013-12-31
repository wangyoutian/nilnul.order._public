using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// for an IComparable, benchmarker is the operation composited.
	/// 
	/// either item1>item2 or item2>item1 must be true.
	/// assymetric, total, transitive,
	/// this is different from =. = can be false both ways.
	/// = is not this case.
	/// 
	/// order is antisymmetric,transitive
	/// </summary>
	public partial interface OrderI<in T>
		//where T:IComparable<T>

		:RelationI2<T>
		//where T:IEquatable<T>
	{
		

	}
}
