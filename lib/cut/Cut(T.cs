using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order.cut
{

		public partial class Cut<T>
			:CutA
			
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

			public Cut(bool eq,T pinpoint )
				:base(eq)
			{
				this.pinpoint_notNull= pinpoint;
			}

			public Cut(order.Bound<T> cut)
				:this(cut.openFalseCloseTrue,cut.pinpoint)
			{

			}

			static public Cut<T> Create(Cut<T> a) {

				return new Cut<T>(a.openFalseCloseTrue, a.pinpoint);
			
			}


		}

	


}
