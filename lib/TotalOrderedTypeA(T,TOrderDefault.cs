using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class TotalOrderedTypeA<T,TOrderDefault>
		:TotalOrderedTypeI2<T,TOrderDefault>

		where TOrderDefault:  TotalOrderI3<T>, new()

	{

		static public readonly TOrderDefault Order = new TOrderDefault();


		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public TotalOrderedTypeA(T value)
		{
			this.val = val;

		}
					


		public TotalOrderI3<T> order
		{
			get { return Order; }
		}
	}

}
