using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.order;

namespace nilnul.order
{
	/// <summary>
	/// greater than
	/// </summary>
	public partial class Gt1<T>
		:   TotalI<T>, AsymmetricI,UpperI<T>
		where T:IComparable<T>,IEquatable<T>
	{
		
		static private readonly Gt1<T> _Instance = new Gt1<T>();
		static public Gt1<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Gt1()
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
