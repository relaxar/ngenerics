/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System.Collections.Generic;
using NGenerics.Extensions;
using NUnit.Framework;

namespace NGenerics.Tests.Extensions.ListExtensionsTests
{
    [TestFixture]
    public class AddRange
    {
        [Test]
        public void Simple()
        {
            IList<int> iList1 = new List<int> { 1, 2, 3, 4 };
            IList<int> iList2 = new List<int> { 5, 6 };

            iList1.AddRange(iList2);

            Assert.AreEqual(6, iList1.Count);
        }
    }
}