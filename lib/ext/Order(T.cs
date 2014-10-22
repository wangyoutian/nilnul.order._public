using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{

	public partial class Order<T>
		:OrderI1<ExtendedI<T>>
	//	where T:IEquatable<T>
	{

		private OrderI1<T> _order;

		public OrderI1<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		public Order(OrderI1<T> order)
		{
			this.order = order;
		}

	




		public bool contains(T a,T b) {

			return order.contains(a, b);
		
		}

	

		public bool contains(ExtendedI<T> a,ExtendedI<T> b) {
			if (a is NegInf<T>)
			{
				return true;
				
			}
			else if (a is ext.Literal<T>)
			{
				if (b is ext.Literal<T>)
				{
					return order.contains((a as Literal<T>).val, (b as Literal<T>).val);
				}
				if (b is PosInf<T>)
				{
					return true;
					
				}
				
			}
			return false;
 
		
		}






		public IEqualityComparer<ExtendedI<T>> elementEq
		{
			get {

				return new Eq<T>(_order.elementEq);
				
				throw new NotImplementedException();
			
			}
		}
	}
}
