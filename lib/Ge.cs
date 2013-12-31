using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  nilnul.order
{
	public partial class Ge<T>
		: TotalI<T>, ReflexiveI<T>,UpperI<T>
		where T:IComparable<T>
		//,IEquatable<T>
	{
		
		static private readonly Ge<T> _Instance = new Ge<T>();
		static public Ge<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Ge()
		{
		}

		public bool exec(T x,T y) {

			return x.Gt(y) || x.Eq(y);
		
		}


		public bool contains(T x, T y)
		{			return x.Gt(y) || x.Eq(y);

			
		}

		
	}

	
}
