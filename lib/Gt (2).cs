using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.interval
{
	/// <summary>
	/// greater than
	/// </summary>
	public partial class Gt<T>
		:OrderI<T>
		where T:IComparable<T>
	{
		
		static private readonly Gt<T> _Instance = new Gt<T>();
		static public Gt<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Gt()
		{
			
		}

		public bool exec(T x,T y) {
			return x.CompareTo(y)>0;
		
		}





		public bool contains(T x	, T y)
		{
						return x.CompareTo(y)>0;

		}
	}

	static public partial class GtX
	{
		static public bool Gt<T>(this T x, T y)
			where T : IComparable<T> {
				return x.CompareTo(y) > 0;
		}
		
	}
}
