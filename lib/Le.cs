using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class Le<T> :
		 LowerI<T>, ReflexiveI<T>
		where T:IComparable<T>
		//,IEquatable<T>
	{
		
		static private readonly Le<T> _Instance = new Le<T>();
		static public Le<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Le()
		{
		}

		public bool contains(T x,T y) {

			return x.Gt(y) || x.Eq(y);
		
		}




		
	}

	static public partial class LeX
	{
		static public bool Le<T>(this T x, T y)
			where T : IComparable<T>
		{
			return x.Eq(y) || x.Lt(y);
		}
		
	}
}
