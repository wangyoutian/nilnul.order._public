using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.order;

namespace nilnul.collection.interval.cut
{
	public partial class LowerByTotalOrderedSet<T>:Cut_TotalOrderedSet<T>
		where T:IComparable<T>
	{

		public LowerByTotalOrderedSet(T pinpoint,LowerI<T> order,bool eq):base(pinpoint,order,eq,false)
		{

		}

		public LowerByTotalOrderedSet(T pinpoint, TotalI<T> order)
			:this(pinpoint,(LowerI<T>) order)
		{


		}

		public LowerByTotalOrderedSet(Cut<T> cut)
			:this(cut.pinpoint,cut.order)
		{
		}
					

		static public bool Is(Cut<T> cut) {

			if (cut.order is nilnul.relation.order.LowerI<T>)
			{
				return true;
				
			}
			return false;
		
		}

		static public bool Not(Cut<T> cut)
		{

			return Is(cut);

		}

		static public void Assert(Cut<T> cut) {

			if (Not(cut))
			{
				throw new Exception();

				
			}
		
		}

		//static public explicit operator Lower<T>(Cut<T> cut)
		//{

		//	Assert(cut);

		//	return new Lower<T>(cut.pinpoint, (LowerI<T>)cut.order);

		//}

		public override string ToString()
		{
			return pinpoint.ToString()+ (eq? "]":")");
		}
					
	}
}
