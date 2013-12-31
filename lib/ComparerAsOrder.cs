using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class ComparerAsOrder<T>
		:
		TotalOrderI3<T>
		
		
	{
		private ComparerI<T> _comparer;

		public NotNull2<ComparerI<T>> comparerNotNull
		{
			get { return _comparer.ToNotNull(); }
			set { _comparer = value.val; }
		}

		public ComparerI<T> comparer { 
				get { return _comparer; }
				set { _comparer = value.EnsureNotNull(); }
		
		}


		


		public ComparerAsOrder(NotNull2< ComparerI<T>> comparer)
		{
			this.comparerNotNull = comparer;
		}

		public ComparerAsOrder(ComparerI<T> comparer)
			:this(comparer.ToNotNull())
		{
		}
					


		

		public bool contains(T first, T second)
		{
			return _comparer.compare(first,second)<=0;
		}
	}
}
