﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Order_FroSysComparer<T>
		:
		TotalOrderI3<T>
		,OrderI<T>
		
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


		


		public Order_FroSysComparer(NotNull2< IComparer<T>> comparer)
		{
			this.comparerNotNull = comparer;
		}

		public Order_FroSysComparer(IComparer<T> comparer)
			:this(comparer.ToNotNull())
		{

		}
					


		

		public bool contains(T first, T second)
		{
			return _comparer.Compare(first,second)<=0;
		}
	}
}
