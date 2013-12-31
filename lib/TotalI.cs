using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{

	
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <see cref="LinearI"/>
	public partial interface TotalI<T>:OrderI<T>
		where T:IComparable<T>
		//,
		//IEquatable<T>
	{
	}
}
