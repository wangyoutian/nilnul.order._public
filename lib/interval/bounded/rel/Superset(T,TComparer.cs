using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.order.interval.bounded.rel
{
	public partial class Superset<T,TComparer>
		:nilnul.obj.rel.Closed<BoundedA_TSysComparer<T,TComparer> >
		where TComparer:IComparer<T>,new()
	{

		public Superset()
			:base(Eval)
		{

		}
		static public TComparer Comparer = SingletonByDefaultNew<TComparer>.Instance;
		static public bool Eval(BoundedA_TSysComparer<T,TComparer> sup, BoundedA_TSysComparer<T,TComparer> sub) {
			bool left;
			if (sup is LeftOpenI)
			{
				if (sub is LeftOpenI)
				{
					left =Comparer.Compare(  sup.lowerBound , sub.lowerBound)<=0;
					
				}
				else
				{
					left = Comparer.Compare(sup.lowerBound, sub.lowerBound) < 0;
				}

			}
			else
			{
				if (sub is LeftOpenI)
				{
					left = Comparer.Compare(sup.lowerBound, sub.lowerBound) <= 0;
					
				}
				else
				{
					left = Comparer.Compare(sup.lowerBound, sub.lowerBound) <= 0;
				}
			}

			bool right=false;

			if (sup is RightOpenI && sub is RightCloseI)
			{
				
				right = Comparer.Compare(sup.upperBound, sub.upperBound) > 0;


			}
			else
			{
				right = Comparer.Compare(sup.upperBound, sup.upperBound) >= 0;
			}

			return left && right;


			throw new NotImplementedException();
		
		}

		static public bool Eval(Open<T,TComparer> sup, Open<T,TComparer> sub) {

			return Comparer.Compare(sup.lowerBound, sub.lowerBound) <= 0 && Comparer.Compare(sup.upperBound,sub.upperBound)>=0;
		
		}

		static public bool Eval(Open<T,TComparer> sup, OpenClose<T,TComparer> sub) {
			return Comparer.Compare(sup.lowerBound, sub.lowerBound) <= 0 && Comparer.Compare(sup.upperBound, sup.upperBound) > 0;
		
		}

		static public bool Eval(Open<T, TComparer> sup, Clopen<T, TComparer> sub)
		{
			return Comparer.Compare(sup.lowerBound, sub.lowerBound) < 0 && Comparer.Compare(sup.upperBound, sup.upperBound) >= 0;

		}

		static public bool Eval(Open<T, TComparer> sup, Close<T, TComparer> sub)
		{
			return Comparer.Compare(sup.lowerBound, sub.lowerBound) < 0 && Comparer.Compare(sup.upperBound, sup.upperBound) > 0;

		}

	

	}
}
