using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Bound<T,TExt>
		:nilnul.order.Bound<TExt>
		where TExt:ExtendedI<T>

	{




		public Bound(bool openFalseCloseTrue, TExt pinpoint)
			: base(openFalseCloseTrue, pinpoint)
		{

		}

		

	

	

		static public bool CloseAndInf(Bound<T> bound)
		{
			return bound.openFalseCloseTrue && bound.pinpoint is InfI;

		}
		static public bool CloseAndInf(order.cut.Cut<ExtendedI<T>> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfI;

		}
		static public bool CloseAndInf(order.Bound<ExtendedI<T>> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfI;

		}
		static public bool Not_CloseAndInf(Bound<T> cut)
		{
			return !CloseAndInf(cut);

		}

		static public bool Not_CloseAndInf(order.cut.Cut<ExtendedI<T>> cut)
		{
			return !CloseAndInf(cut);

		}

		static public bool Not_CloseAndInf(order.Bound<ExtendedI<T>> cut)
		{
			return !CloseAndInf(cut);

		}



	}
}
