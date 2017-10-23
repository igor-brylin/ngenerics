/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.VectorNTests
{
    [TestFixture]
    public class Index
    {

        [Test]
        public void Simple()
        {
            var vector = new VectorN(2);
            Assert.AreEqual(2, vector.DimensionCount);

            Assert.AreEqual(0, vector[0]);
            Assert.AreEqual(0, vector[1]);

            vector[0] = 4;
            vector[1] = 5;

            Assert.AreEqual(4, vector[0]);
            Assert.AreEqual(5, vector[1]);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExceptionTooLarge()
        {
            var vector = new VectorN(2);
            var d = vector[2];
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExceptionTooSmall()
        {
            var vector = new VectorN(2);
            var d = vector[-1];
        }

    }
}