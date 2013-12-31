using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.bound
{
	public class TotalFroStrict<T> :
			total.bound.OrderI<T>
	{

		private StrictOrderI<T> _order;

		public StrictOrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		public TotalFroStrict(StrictOrderI<T> order)
		{
			this.order = order;
		}



		public  bool contains(T first, T second)
		{
			return _order.contains(first, second) || object.Equals(first, second);
		}

		static public TotalFroStrict<T> Create(
			StrictOrderI<T> order
			)
		{
			return new TotalFroStrict<T>(order);
		}




		public T maximum
		{
			get {return order.maximum; }
		}

		public T minimum
		{
			get { return order.minimum; }
		}
	}



}

