<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderIntegers.ascx.cs" Inherits="nilnul.order._web.Ken.OrderIntegers" %>
<p>
	Integers together with the &lt; or &lt;= order is not a well order since it has no least element, or the minimum. Thus there is no ordinal associated with it.</p>
<p>
	But with some other order, it might become a well ordered set.</p>
<p>
	With the isomorphism between natural numbers and integers, which makes them bijective and equivpotent, integer can then become an well ordered set with that order. And the ordinal is
&omega;. It can become a well ordered set of another different order type like ω+ω if you order, say, the natural number first, then the neative number.</p>
<p>
	While the order of reals is a little complex in that the ordering cannot be explicitly representable like what we describe the rules regarding the order of integers. please refer to <a href="http://en.wikipedia.org/wiki/Well-order">http://en.wikipedia.org/wiki/Well-order</a> for more information.</p>
<p>
	&nbsp;</p>
<p>
	The following is adapted from wikipedia.</p>
<h3><span id="Integers" class="mw-headline">Integers</span></h3>
<p>
	Unlike the standard ordering ≤ of the <a href="http://en.wikipedia.org/wiki/Natural_number" title="Natural number">natural numbers</a>, the standard ordering ≤ of the <a href="http://en.wikipedia.org/wiki/Integer" title="Integer">integers</a> is not a well-ordering, since, for example, the set of <a href="http://en.wikipedia.org/wiki/Negative_number" title="Negative number">negative</a> integers does not contain a least element.</p>
<p>
	The following relation <i>R</i> is an example of well-ordering of the integers: <a href="http://en.wikipedia.org/wiki/Binary_relation" title="Binary relation"><i>x R y</i></a> <a href="http://en.wikipedia.org/wiki/If_and_only_if" title="If and only if">if and only if</a> one of the following conditions holds:</p>
<ol>
	<li><i>x</i> = 0</li>
	<li><i>x</i> is positive, and <i>y</i> is negative</li>
	<li><i>x</i> and <i>y</i> are both positive, and <i>x</i> ≤ <i>y</i></li>
	<li><i>x</i> and <i>y</i> are both negative, and |<i>x</i>| ≤ |<i>y</i>|</li>
</ol>
<p>
	This relation <i>R</i> can be visualized as follows:</p>
<dl>
	<dd>0 1 2 3 4 ... −1 −2 −3 ...</dd>
</dl>
<p>
	<i>R</i> is isomorphic to the <a href="http://en.wikipedia.org/wiki/Ordinal_number" title="Ordinal number">ordinal number</a> ω + ω.</p>
<p>
	Another relation for well-ordering the integers is the following definition: <i>x</i> ≤<sub>z</sub> <i>y</i> <a class="mw-redirect" href="http://en.wikipedia.org/wiki/Iff" title="Iff">iff</a> (|<i>x</i>| &lt; |<i>y</i>| or (|<i>x</i>| = |<i>y</i>| and <i>x</i> ≤ <i>y</i>)). This well-order can be visualized as follows:</p>
<dl>
	<dd>0 −1 1 −2 2 −3 3 −4 4 ...</dd>
</dl>
<p>
	This has the <a href="http://en.wikipedia.org/wiki/Order_type" title="Order type">order type</a> ω.</p>
<h3><span id="Reals" class="mw-headline">Reals</span></h3>
<p>
	The standard ordering ≤ of the positive <a href="http://en.wikipedia.org/wiki/Real_number" title="Real number">real numbers</a> is not a well-ordering, since, for example, the open interval (0, 1) does not contain a least element. From the <a class="mw-redirect" href="http://en.wikipedia.org/wiki/ZFC" title="ZFC">ZFC</a> axioms of set theory (including the <a href="http://en.wikipedia.org/wiki/Axiom_of_choice" title="Axiom of choice">axiom of choice</a>) one can show that there is a well-order of the reals. Also <a class="mw-redirect" href="http://en.wikipedia.org/wiki/Sierpinski" title="Sierpinski">Sierpinski</a> proved that ZF + GCH (the <a class="mw-redirect" href="http://en.wikipedia.org/wiki/Generalized_continuum_hypothesis" title="Generalized continuum hypothesis">generalized continuum hypothesis</a>) imply the axiom of choice and hence a well-order of the reals. Nonetheless, it is possible to show that the ZFC+GCH axioms alone are not sufficient to prove the existence of a 
	definable (by a formula) well-order of the reals.<sup id="cite_ref-1" class="reference"><a href="#cite_note-1"><span>[</span>1<span>]</span></a></sup> However it is consistent with ZFC that a definable well-ordering of the reals exists—for example, it is consistent with ZFC that <a class="mw-redirect" href="http://en.wikipedia.org/wiki/V=L" title="V=L">V=L</a>, and it follows from ZFC+V=L that a particular formula well-orders the reals, or indeed any set.</p>
<p>
	An uncountable subset of the real numbers with the standard ordering ≤ cannot be a well-order: Suppose <i>X</i> is a subset of <b>R</b> well-ordered by ≤. For each <i>x</i> in <i>X</i>, let <i>s</i>(<i>x</i>) be the successor of <i>x</i> in ≤ ordering on <i>X</i> (unless <i>x</i> is the last element of <i>X</i>). Let <i>A</i> = { (<i>x</i>, <i>s</i>(<i>x</i>)) | <i>x</i> ∈ <i>X</i> } whose elements are nonempty and disjoint intervals. Each such interval contains at least one rational number, so there is an <a href="http://en.wikipedia.org/wiki/Injective_function" title="Injective function">injective function</a> from <i>A</i> to <b>Q</b>. There is an injection from <i>X</i> to <i>A</i> (except possibly for a last element of <i>X</i> which could be mapped to zero later). And it is well known that there is an injection from <i>Q</i> to the natural numbers (which could be chosen to avoid hitting zero). Thus there is an injection from <i>X</i> to the natural numbers which means that <i>X</i> 
	is countable. On the other hand, a countably infinite subset of the reals may or may not be a well-order with the standard &quot;≤&quot;.</p>
<ul>
	<li>The natural numbers are a well-order.</li>
	<li>The set {1/n : n =1,2,3,...} has no least element and is therefore not a well-order.</li>
</ul>
<p>
	Examples of well-orders:</p>
<ul>
	<li>The set of numbers { − 2<sup>−<i>n</i></sup> | 0 ≤ <i>n</i> &lt; ω } has order type ω.</li>
	<li>The set of numbers { − 2<sup>−<i>n</i></sup> − 2<sup>−<i>m</i>−<i>n</i></sup> | 0 ≤ <i>m</i>,<i>n</i> &lt; ω } has order type ω². The previous set is the set of <a href="http://en.wikipedia.org/wiki/Limit_point" title="Limit point">limit points</a> within the set. Within the set of real numbers, either with the ordinary topology or the order topology, 0 is also a limit point of the set. It is also a limit point of the set of limit points.</li>
	<li>The set of numbers { − 2<sup>−<i>n</i></sup> | 0 ≤ <i>n</i> &lt; ω } ∪ { 1 } has order type ω + 1. With the <a href="http://en.wikipedia.org/wiki/Order_topology" title="Order topology">order topology</a> of this set, 1 is a limit point of the set. With the ordinary topology (or equivalently, the order topology) of the real numbers it is not.</li>
</ul>
<p>
	&nbsp;</p>

