using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.interval
{
	/// <summary>
	/// one or two benchmarkers.
	/// 
	/// constructed by:
	/// one total order on type T.
	/// 
	/// the total order together with set, consititues a TotalOrderedSet.
	/// 
	/// if the set has no maximum, 
	/// 
	/// 
	/// 
	/// 
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Interval<T,TOrderSingleton>
		:
		Interval4<T>
		
	//where T : IComparable<T>
		//where T:IEquatable<T>
		where TOrderSingleton:TotalOrderI3<T>,new()


	{



		#region ctor
		public Interval( Cut left, Cut right)
			:base(new TOrderSingleton(),left,right)
		{
			
			
		}
	

		#endregion

		

		

	

	}


}
