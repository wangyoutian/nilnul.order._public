﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface ComparerI<T>

	{

		 Sign compare(T x, T y);
	}


}
