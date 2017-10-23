/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.MaxPriorityQueueHeapTests
{
    [TestFixture]
    public class RemovePriorityGroup : MaxPriorityQueueTest
    {

        [Test]
        public void WithPriority()
        {
            var priorityQueue = GetTestPriorityQueue();

            Assert.IsTrue(priorityQueue.RemovePriorityGroup(2));
            Assert.AreEqual(priorityQueue.Count, 10);

            Assert.IsTrue(priorityQueue.RemovePriorityGroup(3));
            Assert.AreEqual(priorityQueue.Count, 8);

            Assert.IsTrue(priorityQueue.RemovePriorityGroup(4));
            Assert.AreEqual(priorityQueue.Count, 6);

            Assert.IsTrue(priorityQueue.RemovePriorityGroup(1));
            Assert.AreEqual(priorityQueue.Count, 4);

            // z or f
            var str = priorityQueue.Dequeue();
            Assert.IsTrue(((str == "z") || (str == "f")));

            str = priorityQueue.Dequeue();
            Assert.IsTrue(((str == "z") || (str == "f")));

            // y or e 
            str = priorityQueue.Dequeue();
            Assert.IsTrue(((str == "y") || (str == "e")));

            str = priorityQueue.Dequeue();
            Assert.IsTrue(((str == "y") || (str == "e")));
        }

    }
}