/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.DataStructures.General;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.SkipListTests
{
    [TestFixture]
    public class Count
    {

        [Test]
        public void Simple()
        {
            var skipList = new SkipList<int, string>();
            Assert.AreEqual(skipList.Count, 0);

            skipList.Add(2, "2");
            Assert.AreEqual(skipList.Count, 1);

            skipList.Add(3, "3");
            Assert.AreEqual(skipList.Count, 2);
        }

    }
}