using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Bound<T>
		:nilnul.order.Bound<ExtendedI<T>>

	{

		public Bound(
			nilnul.order.Bound<T> bound	
		)
			:this(bound.openFalseCloseTrue,bound.pinpoint)
		{

		}

		public Bound( order.Bound<ExtendedI<T>> x )
			:this(x.openFalseCloseTrue,x.pinpoint)
		{

		}

		public Bound(
			nilnul.order.cut.Cut<T> cut
	
		)
			:this(new nilnul.order.Bound<T>(cut))
		{

		}

		public Bound(
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

		public Bound(bool openFalseCloseTrue, ExtendedI<T> pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		public bool isInf() {
			return pinpoint is InfI;
		}
		public bool isFinite() {
			return !isInf();
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
