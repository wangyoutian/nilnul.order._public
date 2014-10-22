using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class Order<T>
		:relation.Relation2<T>
	{
		public Order(IEqualityComparer<T> eq)
			:base(eq)
		{

		}



	}
}
