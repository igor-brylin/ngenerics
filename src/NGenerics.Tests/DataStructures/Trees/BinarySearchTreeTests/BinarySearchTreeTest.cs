/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/



using NGenerics.DataStructures.Trees;

namespace NGenerics.Tests.DataStructures.Trees.BinarySearchTreeTests
{
    public class BinarySearchTreeTest
    {

        internal static BinarySearchTree<int, string> GetTestTree()
        {
            var tree = new BinarySearchTree<int, string>
			                                         {
			                                             {4, "4"},
			                                             {6, "6"},
			                                             {2, "2"},
			                                             {5, "5"},
			                                             {19, "19"},
			                                             {1, "1"}
			                                         };

            return tree;
        }

    }
}