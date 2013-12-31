using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.relation.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order.interval
{
	

		public partial class Cut<T>
			:IEquatable<Cut<T>>
		{

			public T pinpoint;

			public bool eq;

			public Cut(T pinpoint)
				:this(pinpoint,false)
			{
				
			}

			public Cut(T pinpoint, bool eq)
			{
				this.pinpoint = pinpoint;
				this.eq = eq;
			}




			public bool Equals(Cut<T> other)
			{

				return EqualityComparer<T>.Default.Equals(this.pinpoint, other.pinpoint) && this.eq == other.eq;
				;
			}


			public class EqualityComparer 
				:IEqualityComparer<Cut<T>>
			{
				public bool Equals(Cut<T> x, Cut<T> y)
				{
					return EqualityComparer<T>.Default.Equals(x.pinpoint, y.pinpoint) && x.eq == y.eq;

					throw new NotImplementedException();
				}

				public int GetHashCode(Cut<T> obj)
				{
					return obj.GetHashCode()^obj.eq.GetHashCode();
				}
			}
		}

	


}
