using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Gt_boxComparer<T>
		:
		TotalOrderI3<T>
		
	{
		private IComparer<T> _comparer;

		public NotNull2<IComparer<T>> comparerNotNull
		{
			get { return _comparer.ToNotNull(); }
			set { _comparer = value.val; }
		}

		public IComparer<T> comparer { 
				get { return _comparer; }
				set { _comparer = value.EnsureNotNull(); }
		
		}


		


		public Gt_boxComparer(NotNull2< IComparer<T>> comparer)
		{
			this.comparerNotNull = comparer;
		}

		public Gt_boxComparer(IComparer<T> comparer)
			:this(comparer.ToNotNull())
		{

		}
					


		

		public bool contains(T first, T second)
		{
			return _comparer.Compare(first,second)>=0;
		}
	}
}
