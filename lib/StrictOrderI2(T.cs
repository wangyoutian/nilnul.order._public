using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// definition: if an order is also asymmetric, it's strict.
	/// 
	/// corrolary: a strict order is asymmetric and transitive.
	/// </summary>
	/// <remarks>
	///		<example>
	///			<ul>
	///				<li>
	///					properSubset is strict for it's asymmetric.
	///				</li>
	///				<li>
	///				</li>
	///			</ul>
	///		</example>
	///		<counterExample>
	///			<ul>
	///				<li>
	///					subset is not strict for it's not asymmetric.
	///				</li>
	///			</ul>
	///		</counterExample>
	///		  irreflexive, transitive and antisymmetric.
	/// </remarks>
	public partial interface StrictOrderI2<in T>
		:
		nilnul.relation.AsymmetricRelationI2<T>
		,nilnul.relation.TransitiveRelationI<T>
	{


	}
}
