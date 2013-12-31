using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.interval
{
	public partial class Eq<T>
		:OrderI<T>
		where T:IComparable<T>
	{
		
		static private readonly Eq<T> _Instance = new Eq<T>();
		static public Eq<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Eq()
		{
		}

		public bool exec(T x, T y) {
			return x.CompareTo(y) == 0;
		}


		public bool contains(T item1, T item2)
		{		return item1.CompareTo(item2) == 0;
			
		}
	}

	static public partial class EqX {
		static public bool Eq<T>(this T x,T y)
			where T:IComparable<T>
			{
				return x.CompareTo(y) == 0;
		
			}
	
	}

	
}
