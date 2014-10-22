using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;

namespace nilnul.order
{
	/// <summary>
	/// IComparable is treated linears.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface LinearI<T>
		:OrderI<T>
		//where T:IComparable<T>
		//where T:IEquatable<T>
	{
		
	}

	

	
}
