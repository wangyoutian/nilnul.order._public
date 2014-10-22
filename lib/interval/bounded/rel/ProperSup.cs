using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.rel.k
{
	public partial class ProperSup<T, TComparer>
		: 
		nilnul.obj.rel.Closed<BoundedA_TSysComparer<T, TComparer>>

		where TComparer : IComparer<T>, new()
	{

		static public TComparer Comparer = SingletonByDefault<TComparer>.Instance;

		static public bool Eval(BoundedA_TSysComparer<T, TComparer> sup, BoundedA_TSysComparer<T, TComparer> sub)
		{

			return Joint<T,TComparer>.Eval(sub,sup);


			throw new NotImplementedException();

		}



		public ProperSup()
			: base(Eval)
		{

		}




	}
}
