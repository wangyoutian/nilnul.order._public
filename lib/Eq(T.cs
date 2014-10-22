using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  nilnul.order
{
	public partial class Eq<T>
		:  ReflexiveI<T>
		where T:IComparable<T>
		//,IEquatable<T>
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

	

	
}
