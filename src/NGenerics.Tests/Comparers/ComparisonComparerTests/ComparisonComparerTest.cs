/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/



using NGenerics.Comparers;
using NGenerics.Tests.Util;

namespace NGenerics.Tests.Comparers.ComparisonComparerTests
{

    public class ComparisonComparerTest
    {
        internal static ComparisonComparer<SimpleClass> GetTestComparer()
        {
            return new ComparisonComparer<SimpleClass>((x, y) => x.TestProperty.CompareTo(y.TestProperty));
        }
    }
}
