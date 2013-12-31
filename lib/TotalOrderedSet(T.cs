using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class TotalOrderedSet<T>
		where T:IEquatable<T>
	{
		private TotalOrderA<T> _order;

		public TotalOrderA<T>	order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		public TotalOrderedSet(TotalOrderA<T> order)
		{
			this.order = order;
		}

	
					
	}
}
