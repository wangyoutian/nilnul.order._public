using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.order;

namespace nilnul.collection.interval.cut
{
	public partial class Upper<T>:Cut<T>
		where T:IComparable<T>
	{

		public Upper(T pinpoint, UpperI<T> order)
			: base(pinpoint, order)
		{

		}
		public Upper(T pinpoint, OrderI<T> order)
			: this(pinpoint, (UpperI<T>)order)
		{

		}

		public Upper(Cut<T> cut):this(cut.pinpoint,cut.order)
		{
		}
					

		static public bool Is(Cut<T> cut) {
			if (cut.order is nilnul.relation.order.UpperI<T>)
			{
				return true;
				
			}
			return false;
		}

		static public bool Not(Cut<T> cut) {
			return !Is(cut);
		}

		static public void Assert(Cut<T> cut) {
			if (Not(cut))
			{
				throw new Exception();
				
			}
		
		
		}


		//static public implicit operator Upper<T>(Cut<T> cut){
		//	//UpperX.AssertUpper(cut.order);
			
		//		return new Upper<T>(cut.pinpoint,(cut.order));
		 
			
	
		//}

		public override string ToString()
		{
			return (order is ReflexiveI<T> ? "[" : "(" )+ pinpoint.ToString();
		}
					
	}
}
