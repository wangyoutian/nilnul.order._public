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
	public partial class UpperBound1<T>
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
		
		

		public UpperBound1(order.Bound<T> cut,OrderI1<T> order)
			
		{
			this._cut = cut;
			this._order = order;

		}





		public bool contains(T item)
		{
			return 
				
				cut.openFalseCloseTrue ?
				(_order.contains( item,_cut.pinpoint))
				:
				(_order.contains( item,_cut.pinpoint) && !order.elementEq.Equals(cut.pinpoint, item))
			;
			
			throw new NotImplementedException();
		}
	}
}
