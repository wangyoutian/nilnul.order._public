using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public interface LinearUnboundI<T> : 
		LinearI<T>, 
		UnboundI<T>
		where T:IEquatable<T>
	{


	}
}
