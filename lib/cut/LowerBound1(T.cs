using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComparer"></typeparam>
	public partial class LowerBound1<T>
		:
		//Cut<T>
		//,
		//ComparerAsPropI<T>
		//,
		nilnul.collection.ContainsI<T>
	{

		private order.Bound<T> _cut;

		public order.Bound<T> cut
		{
			get { return _cut; }
			set { _cut = value; }
		}

		private OrderI1<T> _order;

		public OrderI1<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		

		public LowerBound1(order.Bound<T> cut,OrderI1<T> order)
			
		{
			this._cut = cut;
			this._order = order;

		}





		public bool contains(T item)
		{
			return 
				
				cut.openFalseCloseTrue ?
				(_order.contains(_cut.pinpoint, item))
				:
				(_order.contains(_cut.pinpoint, item) && !order.elementEq.Equals(cut.pinpoint, item))
			;
			
			throw new NotImplementedException();
		}
	}
}
