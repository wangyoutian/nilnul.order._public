using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.interval
{
	public partial class Ge<T>
		:OrderI<T>
		where T:IComparable<T>
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

	static public partial class GeX
	{
		static public bool Ge<T>(this T x, T y)
			where T : IComparable<T>
		{
			return x.Eq(y) || x.Gt(y);
		}
		
	}
}
