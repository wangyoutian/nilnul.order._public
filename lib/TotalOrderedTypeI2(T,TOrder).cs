using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface TotalOrderedTypeI2<T, TOrderDefault>
	
		where TOrderDefault : TotalOrderI3<T>, new()
	{
		TotalOrderI3<T> order
		{
			get;
		}

	}





}
