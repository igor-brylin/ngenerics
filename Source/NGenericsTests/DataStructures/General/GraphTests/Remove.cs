/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System.Collections.Generic;
using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.GraphTests
{
    [TestFixture]
    public class Remove : GraphTest
    {
        [Test]
        public void Interface()
        {
            var graph = new Graph<int>(true);
            ((ICollection<int>)graph).Add(4);
            Assert.AreEqual(graph.Vertices.Count, 1);

            Assert.IsTrue(((ICollection<int>)graph).Remove(4));
            Assert.AreEqual(graph.Vertices.Count, 0);
            Assert.IsFalse(((ICollection<int>)graph).Remove(3));
            Assert.AreEqual(graph.Vertices.Count, 0);
        }
    }
}