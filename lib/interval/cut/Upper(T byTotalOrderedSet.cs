using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;
using nilnul.relation.order;

namespace nilnul.collection.interval.cut
{
	public partial class Upper1<T>:Cut_TotalOrderedSet<T>
		where T:IComparable<T>
	{

		public Upper1(T pinpoint, TotalOrderI<T> order,bool eq)
			: base(pinpoint, order,eq,true)
		{

		}
		public Upper1(T pinpoint, OrderI<T> order)
			: this(pinpoint, (UpperI<T>)order)
		{

		}

		public Upper1(Cut<T> cut):this(cut.pinpoint,cut.order)
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
			return (eq ? "[" : "(" )+ pinpoint.ToString();
		}
					
	}
}
