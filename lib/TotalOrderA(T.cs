using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set.relation.order;

namespace nilnul.order
{
	/// <summary>
	/// establish order, a relation, on type T.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract partial class TotalOrderA<T> 
		:
		nilnul.order.TotalOrderI<T>
		,
		LinearI<T>
		//where T:IEquatable<T>
	{

		
				

		#region MyRegion
		
		public bool gt(T x,T y) {
			return compare(x, y) == Sign.Gt;
		}

		public bool lt(T x, T y){

				return compare(x, y) == Sign.Lt;

		}

		public bool eq(T x, T y) {
			return compare(x, y) == Sign.Eq;
		
		}

		public bool neq(T x, T y)
		{
			return !eq(x,y);

		}



		public bool ge(T x, T y) {
			return gt(x, y) || eq(x, y);
		
		}

		public bool le(T x, T y)
		{
			return lt(x, y) || eq(x, y);

		}



		public abstract Sign compare(T x, T y);
		#endregion

		#region subclass Cut
		public partial class Cut
		{
			public T pinpoint;

			public bool eq;


			public Cut(T pinpoint)
			{
				this.pinpoint = pinpoint;
				eq = true;
			}

			public Cut(T pinpoint,bool eq)
				:this(pinpoint)
			{
				this.eq = eq;
			}


		}
		#endregion



		public bool contains(T item1, T item2)
		{
			return lt(item1,item2);
		}

	
	}
}
