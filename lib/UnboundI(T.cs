using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// an order on T can be unbound.
	/// 
	/// </summary>
	public partial interface UnboundI<T> : OrderI<T>
		//where T:IEquatable<T>
	{


	}

	
}
