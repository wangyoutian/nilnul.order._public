<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransitiveReduce.ascx.cs" Inherits="nilnul.order._web.Ken.TransitiveReduce" %>

<p>
	The transitive reduction of a <a href="http://xlinux.nist.gov/dads/HTML/directedGraph.html"><em>directed graph</em></a> G is the directed graph G&#39; with the smallest number of <a href="http://xlinux.nist.gov/dads/HTML/edge.html"><em>edges</em></a> such that for every <a href="http://xlinux.nist.gov/dads/HTML/path.html"><em>path</em></a> between <a href="http://xlinux.nist.gov/dads/HTML/vertex.html"><em>vertices</em></a> in G, G&#39; has a path between those vertices.
</p>
<p>
	<code>Adjacency matrix<br />
	0, 1, 1, 0, 0<br />
	0, 0, 0, 0, 0<br />
	0, 0, 0, 1, 1<br />
	0, 0, 0, 0, 1<br />
	0, 1, 0, 0, 0<br />
	<br />
	After Hsu<br />
	0, 1, 1, 0, 0<br />
	0, 0, 0, 0, 0<br />
	0, 0, 0, 1, 0<br />
	0, 0, 0, 0, 1<br />
	0, 1, 0, 0, 0<br />
	<br />
	Path matrix<br />
	0, 1, 1, 1, 1<br />
	0, 0, 0, 0, 0<br />
	0, 1, 0, 1, 1<br />
	0, 1, 0, 0, 1<br />
	0, 1, 0, 0, 0<br />
	<br />
	After Hsu<br />
	0, 0, 1, 0, 0<br />
	0, 0, 0, 0, 0<br />
	0, 0, 0, 1, 0<br />
	0, 0, 0, 0, 1<br />
	0, 1, 0, 0, 0<br />
	</code>
</p>

