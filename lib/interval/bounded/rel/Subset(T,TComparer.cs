using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.order.interval.bounded.rel
{
	public partial class Subset<T,TComparer>
		:nilnul.obj.rel.Closed<BoundedA_TSysComparer<T,TComparer> >
		where TComparer:IComparer<T>,new()
	{

		static public bool Eval(
			BoundedA_TSysComparer<T, TComparer> sub
			, 
			BoundedA_TSysComparer<T, TComparer> sup
			
		) {

			return Superset<T, TComparer>.Eval(sup, sub);
		
		
		}


		public Subset()
			:base(Eval)
		{

		}
		

	

	}
}
