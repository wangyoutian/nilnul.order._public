﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface TotalOrderedTypeI<T>
	{
		TotalOrderI3<T> order
		{
			get;
		}

	}





}