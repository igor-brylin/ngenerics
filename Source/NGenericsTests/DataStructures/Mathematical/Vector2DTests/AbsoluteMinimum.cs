/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.Vector2DTests
{
    [TestFixture]
    public class AbsoluteMinimum
    {

        [Test]
        public void Simple()
        {
            var vector = new Vector2D(1, -4);

            Assert.AreEqual(1, vector.AbsoluteMinimum());

            Assert.AreEqual(1, vector.X);
            Assert.AreEqual(-4, vector.Y);
        }

    }
}