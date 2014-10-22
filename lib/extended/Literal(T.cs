using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	

		

		public class Literal<T> :ExtendedTypeI2<T> 
		//where T:IEquatable<T>
		{
			
			
			private T _literal;

			public T literal
			{
				get { return _literal; }
				set { _literal = value; }
			}

			public T val { 
				get{
					return _literal;
			
				}
			}

			public Literal(T literal)
				
			{
				this._literal = literal;
				//this._order = order;
			}

			public override string ToString()
			{
				return literal.ToString();
			}


			public bool Equals(ExtendedTypeI2<T> other)
			{
				throw new NotImplementedException();
			}
		}



		




					
	
}
