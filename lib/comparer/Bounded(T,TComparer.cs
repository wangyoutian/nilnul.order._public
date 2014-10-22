using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Bounded<T,TComparer>
		: 
		Bounded<T>
		,

		nilnul.collection.ContainsI<T>

		where TComparer:IComparer<T>,new()
	{
		

		public Bounded(order.Bound<T> lower, order.Bound<T> upper)
			: base(lower, upper,SingletonByDefault<TComparer>.Instance)
		{

		}




	
	}
}
