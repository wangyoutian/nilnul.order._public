using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	public partial class Cut<T>
		:nilnul.order.cut.Cut<ExtendedTypeI2<T>>

	{

		public Cut(
			nilnul.order.Bound<T> cut	
		)
			:this(cut.openFalseCloseTrue,cut.pinpoint)
		{

		}

		public Cut(
			nilnul.order.cut.Cut<T> cut
	
		)
			:this(new nilnul.order.Bound<T>(cut))
		{

		}

		public Cut(
			bool openFalseCloseTrue
			,
			T pinpoint
		)
			:this(openFalseCloseTrue, new Literal<T>(pinpoint))
		{

		}

		public Cut(bool openFalseCloseTrue, ExtendedTypeI2<T> pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		static public bool CloseAndInfOrNegInf(Cut<T> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfOrNegInfI;

		}
		static public bool CloseAndInfOrNegInf(order.cut.Cut<ExtendedTypeI2< T>> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfOrNegInfI;

		}
		static public bool Not_CloseAndInfOrNegInf(Cut<T> cut)
		{
			return !CloseAndInfOrNegInf(cut);

		}

		static public bool Not_CloseAndInfOrNegInf(order.cut.Cut<ExtendedTypeI2< T>> cut)
		{
			return !CloseAndInfOrNegInf(cut);

		}



	}
}
