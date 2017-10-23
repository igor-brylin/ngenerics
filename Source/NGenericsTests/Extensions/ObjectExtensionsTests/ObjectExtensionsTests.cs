﻿/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/


using NGenerics.Extensions;
using NUnit.Framework;

namespace NGenerics.Tests.Extensions.ObjectExtensionsTests
{
        [TestFixture]
        public class Convert
        {
            [Test]
            public void Simple()
            {
                var str = "134";
                var x = str.ConvertTo<int>();
                Assert.AreEqual(x, 134);
            }
        }
    }
