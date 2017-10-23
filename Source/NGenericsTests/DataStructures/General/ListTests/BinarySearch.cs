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

namespace NGenerics.Tests.DataStructures.General.ListTests
{
    [TestFixture]
    public class BinarySearch
    {
        [Test]
        public void Simple()
        {
            var listBase = new ListBase<int> {3, 4, 5};
            Assert.AreEqual(2, listBase.BinarySearch(5));
        }
        [Test]
        public void Comparer()
        {
            var listBase = new ListBase<int> {3, 4, 5};
            Assert.AreEqual(2, listBase.BinarySearch(5, Comparer<int>.Default));
        }
        [Test]
        public void ComparerIndex()
        {
            var listBase = new ListBase<int> {3, 4, 5};
            Assert.AreEqual(2, listBase.BinarySearch(0, 3, 5, Comparer<int>.Default));
        }
    }
}