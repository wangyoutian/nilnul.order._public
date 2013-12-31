using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.interval._
{
	/// <summary>
	/// interval must be ordered.
	/// 
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public partial class Interval<T>:Tuple<T,T>
		where T:IComparable<T>
    {
		public virtual T left {
			get {
				return Item1;
			}
			
		}

		public virtual T right {
			get {
				return Item2;
			}
			
		}

		public bool contains(T item) {
			if (item.CompareTo(left)<0)
			{
				return false;
				
			}
			if (item.CompareTo(right)>0)
			{
				return false;
				
			}
			return true;
		
		}

		public Interval(T left,T right):base(left,right)
		{

		}
					
		
    }
}
