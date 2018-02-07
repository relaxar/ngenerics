/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.Graphs;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.EdgeTests
{
    [TestFixture]
    public class Construction
    {
        [Test]
        public void Edge()
        {
            var vertex1 = new Vertex<int>(6);
            var vertex2 = new Vertex<int>(4);

            var edge = new Edge<int>(vertex1, vertex2, true);
            Assert.AreEqual(vertex1, edge.FromVertex);
            Assert.AreEqual(vertex2, edge.ToVertex);
            Assert.AreEqual(0, edge.Weight);

            edge = new Edge<int>(vertex1, vertex2, 55, true);
            Assert.AreEqual(vertex1, edge.FromVertex);
            Assert.AreEqual(vertex2, edge.ToVertex);
            Assert.AreEqual(55, edge.Weight);

            edge = new Edge<int>(vertex1, vertex2, -2, true);
            Assert.AreEqual(vertex1, edge.FromVertex);
            Assert.AreEqual(vertex2, edge.ToVertex);
            Assert.AreEqual(-2, edge.Weight);
        }

        [Test]
        public void ExceptionNullFromVertexDirected()
        {
            Assert.Throws<ArgumentNullException>(() => new Edge<int>(null, new Vertex<int>(4), true));
        }

        [Test]
        public void ExceptionNullToVertexDirected()
        {
            Assert.Throws<ArgumentNullException>(() => new Edge<int>(new Vertex<int>(4), null, true));
        }

        [Test]
        public void ExceptionNullFromVertexUndirected()
        {
            Assert.Throws<ArgumentNullException>(() => new Edge<int>(null, new Vertex<int>(4), false));
        }

        [Test]
        public void ExceptionNullToVertexUndirected()
        {
            Assert.Throws<ArgumentNullException>(() => new Edge<int>(new Vertex<int>(4), null, false));
        }
    }
}