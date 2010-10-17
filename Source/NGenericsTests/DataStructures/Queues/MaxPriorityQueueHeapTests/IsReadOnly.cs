/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Queues;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.MaxPriorityQueueHeapTests
{
    [TestFixture]
    public class IsReadOnly : MaxPriorityQueueTest
    {

        [Test]
        public void Simple()
        {
            var priorityQueue = new PriorityQueue<int, int>(PriorityQueueType.Maximum);
            Assert.IsFalse(priorityQueue.IsReadOnly);

            priorityQueue.Add(4);
            Assert.IsFalse(priorityQueue.IsReadOnly);

            priorityQueue.Add(99);
            Assert.IsFalse(priorityQueue.IsReadOnly);

            priorityQueue.Clear();
            Assert.IsFalse(priorityQueue.IsReadOnly);
        }

    }
}