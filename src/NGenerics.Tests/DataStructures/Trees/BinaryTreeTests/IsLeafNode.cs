/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.BinaryTreeTests
{
    [TestFixture]
    public class IsLeafNode : BinaryTreeTest
    {

        [Test]
        public void Simple()
        {
            var binaryTree = GetTestTree();
            Assert.IsFalse(binaryTree.IsLeafNode);
            Assert.IsTrue(binaryTree.GetChild(0).GetChild(0).IsLeafNode);

            binaryTree.Clear();
            Assert.IsTrue(binaryTree.IsLeafNode);
        }

    }
}