using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// greater than
	/// </summary>
	public partial class Gt<T>
		:   TotalI<T>, AsymmetricI,UpperI<T>
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

	
}
