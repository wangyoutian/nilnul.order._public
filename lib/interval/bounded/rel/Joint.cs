using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.rel
{
	public partial class Joint<T, TComparer>
		: nilnul.obj.rel.Closed<BoundedA_TSysComparer<T, TComparer>>
		where TComparer : IComparer<T>, new()
	{

		static public TComparer Comparer = SingletonByDefault<TComparer>.Instance;

		static public bool Eval(BoundedA_TSysComparer<T, TComparer> sub, BoundedA_TSysComparer<T, TComparer> sup)
		{


			return Subset<T, TComparer>.Eval(sub, sup) && Neq<T, TComparer>.Eval(sub, sup);


			throw new NotImplementedException();

		}



		public Joint()
			: base(Eval)
		{

		}




	}
}
