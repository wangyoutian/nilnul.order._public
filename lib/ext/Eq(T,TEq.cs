using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Eq<T,TEq>
		:
		Eq<T>
		where TEq:IEqualityComparer<T>,new()
	{

		static public Eq<T, TEq> Singleton = SingletonByDefault<Eq<T, TEq>>.Instance;

		public Eq()
			:base(new TEq())
		{

		}

		static public bool Eval(ExtendedI<T> a, ExtendedI<T> b) {

			return Singleton.Equals(a, b);
			
		}




	

	}
}
