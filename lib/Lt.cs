using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class Lt<T> : DownwardI, LowerI<T>, AsymmetricI
		where T:IComparable<T>
		//,IEquatable<T>
	{
		
		static private readonly Lt<T> _Instance = new Lt<T>();
		static public Lt<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Lt()
		{
		}

		public bool contains(T x, T y) {
			return x.CompareTo(y) <0;
		}




		
		
	}

	static public partial class LtX
	{
		static public bool Lt<T>
			(this T x, T y)
		where T:IComparable<T>{
			return x.CompareTo(y) < 0;
		
		}
		
	}
}
