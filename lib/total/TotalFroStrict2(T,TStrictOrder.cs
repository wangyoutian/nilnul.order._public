using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public class TotalFroStrict<TElement,TStrictOrder> :
			OrderI<TElement>
		where TStrictOrder:StrictOrderI2<TElement>
	{

		private TStrictOrder _order;

		public TStrictOrder order
		{
			get { return _order; }
			set { _order = value; }
		}

		public TotalFroStrict(TStrictOrder order)
		{
			this.order = order;
		}



		public  bool contains(TElement first, TElement second)
		{
			return _order.contains(first, second) || object.Equals(first, second);
		}

		static public TotalFroStrict<TElement,TStrictOrder> Create(
			TStrictOrder order
			)
		{
			return new TotalFroStrict<TElement,TStrictOrder>(order);
		}



	}




}
