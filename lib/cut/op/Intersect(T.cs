using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.op
{
	public partial class Intersect<T>
	{
		static public Pair<T> Eval(Pair<T> a,Pair<T> b, IComparer<T> c) {

			return new Pair<T>(
				Eval_lowerBound(a.lower,b.lower,c)
				,
				Eval_upperBound(a.upper,b.upper,c)
				
			);
		}

		static public Cut<T> Eval_lowerBound(Cut<T> a,Cut<T> b, IComparer<T> comparer) {
			if (a==null)
			{

				return b==null? null:new Cut<T>(b.openFalseCloseTrue, b.pinpoint);
				
			}
			if (b==null)
			{
				return Eval_lowerBound(b, a, comparer);
			}

			if (comparer.Compare(a.pinpoint,b.pinpoint)==0)
			{
				if (a.openFalseCloseTrue && b.openFalseCloseTrue)
				{
					return new Cut<T>(true, a.pinpoint);
					
				}
				return new Cut<T>(false, a.pinpoint);
				
			}
			if (comparer.Compare(a.pinpoint,b.pinpoint)<0)
			{
				return Cut<T>.Create(b);
				
			}
			return Cut<T>.Create(a);
		
		}

		static public Cut<T> Eval_lowerBound(IComparer<T> comparer, IEnumerable<Cut<T>> cuts) {
			if (cuts.Count()==0)
			{
				return null;
				
			}
			return Eval_lowerBound(
				cuts.First()
				,
				Eval_lowerBound(comparer,cuts.Skip(1))
				,
				comparer
			);

			throw new NotImplementedException();
		}

		static public Cut<T> Eval_upperBound(Cut<T> a,Cut<T> b, IComparer<T> comparer) {
			if (a==null)
			{

				return b==null? null:Cut<T>.Create(b);
				
			}
			if (b==null)
			{
				return Eval_lowerBound(b, a, comparer);
			}

			if (comparer.Compare(a.pinpoint,b.pinpoint)==0)
			{
				if (a.openFalseCloseTrue && b.openFalseCloseTrue)
				{
					return new CloseCut<T>( a.pinpoint);
					
				}
				return new OpenCut<T>( a.pinpoint);
				
			}
			if (comparer.Compare(a.pinpoint,b.pinpoint)<0)
			{
				return Cut<T>.Create(a);
				
			}
			return Cut<T>.Create(b);
		
		}

		static public Cut<T> Eval_upperBound(
			IComparer<T> comparer
			,
			IEnumerable<Cut<T>> cuts
			
		) {

			if (cuts.Count()==0)
			{
				return null;
				
			}
			return Eval_upperBound(
				cuts.First()
				,
				Eval_upperBound(
						comparer,
						cuts.Skip(1)
						
		
				)
				,
				
				comparer

			);

			throw new NotImplementedException();
		}



	}
}
