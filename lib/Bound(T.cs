using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order
{

		public partial class Bound<T>
			:BoundA
			
		{

			private T _pinpoint;

			public T pinpoint
			{
				get { return _pinpoint; }
				
			}

			public T pinpoint_notNull {

				get {
					return _pinpoint;
				}
				set {
					_pinpoint=value.EnsureNotNull();
				}
			}


			public bool eq {
				get {
					return openFalseCloseTrue;
				}
			}

			public Bound(bool eq,T pinpoint )
				:base(eq)
			{
				this.pinpoint_notNull= pinpoint;
			}

			public Bound(nilnul.order.cut.Cut<T> cut)
				:this(cut.openFalseCloseTrue,cut.pinpoint)
			{

			}

			public override string ToString()
			{
				return "["+pinpoint.ToString() + ","+openFalseCloseTrue.ToString()+"]";
			}

			static public Bound<T> Create(Bound<T> a) {

				return new Bound<T>(a.openFalseCloseTrue, a.pinpoint);
			
			}




		}

	


}
