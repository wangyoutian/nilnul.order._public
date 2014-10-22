using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Cut<T>
		:nilnul.order.Bound<ExtendedI<T>>

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
			:this(
			openFalseCloseTrue
			, 
			
			new Literal<T>(pinpoint) as ExtendedI<T>
			)
		{

		}

		public Cut(bool openFalseCloseTrue, ExtendedI<T> pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		static public bool CloseAndInfOrNegInf(Cut<T> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfI;

		}
		static public bool CloseAndInfOrNegInf(order.cut.Cut<ExtendedI< T>> cut)
		{
			return cut.openFalseCloseTrue && cut.pinpoint is InfI;

		}
		static public bool Not_CloseAndInfOrNegInf(Cut<T> cut)
		{
			return !CloseAndInfOrNegInf(cut);

		}

		static public bool Not_CloseAndInfOrNegInf(order.cut.Cut<ExtendedI< T>> cut)
		{
			return !CloseAndInfOrNegInf(cut);

		}



	}
}
