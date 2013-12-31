using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// combine the order of type T, and the infinte, and the instances.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ExtendedType<T>
		where T:IEquatable<T>
	{
		private UnboundI<T> _order;
		public UnboundI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		//private InfiniteI<T> _infinite;

		//public InfiniteI<T> infinite
		//{
		//	get { return _infinite; }
		//	set { _infinite = value; }
		//}

		public ExtendedType(UnboundI<T> order)
		{
			this.order = order;
			//this.infinite = new Infinite<T>(order);
		}

		public Literal create(T literal) {
			return new Literal(literal,order);
		
		}

		public Infinite createInfinite() {
			return new Infinite(order);
		
		}



		public class Instance {

			private UnboundI<T> _order;

			public UnboundI<T> order
			{
				get { return _order; }
				set { _order = value; }
			}

			public Instance(UnboundI<T> order)
			{
				this.order = order;
			}


					
			
		
		}


		public class Infinite :Instance{


			public Infinite(UnboundI<T> order)
				:base(order)
			{

			}
					
		
		}

		public class Literal : Instance {
			private UnboundI<T> _order;

			public UnboundI<T> order
			{
				get { return _order; }
				set { _order = value; }
			}
			
			private T _literal;

			public T literal
			{
				get { return _literal; }
				set { _literal = value; }
			}

			public Literal(T literal, UnboundI<T> order)
				:base(order)
			{
				this._literal = literal;
				//this._order = order;
			}
					
			
		}



		




					
	}
}
