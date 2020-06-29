using LinqLogic.Domain;
using LinqLogic.UnitTests.Mock;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqLogic.UnitTests
{
    public class LinqFunctionsTest
    {
        public LinqFunctions uut = new LinqFunctions();

        public class CombineListsMethod : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var t5 = new LinqModel(5, "5");
                var list1 = new List<LinqModel> { t1, t2, t3 };
                var list2 = new List<LinqModel> { t3, t4, t5 };

                // Act
                var result = uut.CombineLists(list1, list2);

                // Assert
                Assert.True(result.Count() == 5);
                Assert.Contains(t1, result);
                Assert.Contains(t2, result);
                Assert.Contains(t3, result);
                Assert.Contains(t4, result);
                Assert.Contains(t5, result);
            }
        }

        public class ExceptOfListsMethod : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var t5 = new LinqModel(5, "5");
                var list1 = new List<LinqModel> { t1, t2, t3 };
                var list2 = new List<LinqModel> { t3, t4, t5 };

                // Act
                var result = uut.ExceptOfLists(list1, list2);

                // Assert
                Assert.True(result.Count() == 4);
                Assert.Contains(t1, result);
                Assert.Contains(t2, result);
                Assert.Contains(t4, result);
                Assert.Contains(t5, result);
            }
        }

        public class ExistsInTableTest : LinqFunctionsTest
        {
            [Fact]
            public void ExistsInTableByReference()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var list = new List<LinqModel> { t1, t2, t3 };

                // Act
                var result = uut.ExistsInTable(t1, list);

                // Assert
                Assert.True(result);
            }

            [Fact]
            public void ExistsInTableByEqualityOperator()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var list = new List<LinqModel> { t1, t2, t3 };

                var t4 = new LinqModel(3, "3");

                // Act
                var result = uut.ExistsInTable(t4, list);

                // Assert
                Assert.True(result);
            }
        }

        public class FlattenListOfListsTest : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var t5 = new LinqModel(5, "5");
                var list1 = new List<LinqModel> { t1, t2, t3 };
                var list2 = new List<LinqModel> { t3, t4, t5 };
                var listOfLists = new List<List<LinqModel>> { list1, list2 };

                // Act
                var result = uut.FlattenListOfLists(listOfLists);

                // Assert
                Assert.True(result.Count() == 5);
                Assert.Contains(t1, result);
                Assert.Contains(t2, result);
                Assert.Contains(t3, result);
                Assert.Contains(t4, result);
                Assert.Contains(t5, result);
            }
        }

        public class GetDistinctPairsTest : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var list = new List<LinqModel> { t1, t2, t3, t4 };

                // Act
                var result = uut.GetDistinctPairs(list);

                // Assert
                Assert.True(result.Count() == 6);
            }
        }

        public class GetDuplicatesFromListTest : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var list = new List<LinqModel> { t1, t1, t2, t3, t3, t4 };

                // Act
                var result = uut.GetDuplicatesFromList(list);

                // Assert
                Assert.True(result.Count() == 2);
                Assert.Contains(t1, result);
                Assert.Contains(t3, result);
            }
        }

        public class GetListOfDistinctObjectsTest : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var list = new List<LinqModel> { t1, t1, t2, t3, t3, t4 };

                // Act
                var result = uut.GetListOfDistinctObjects(list);

                // Assert
                Assert.True(result.Count() == 4);
                Assert.Contains(t1, result);
                Assert.Contains(t2, result);
                Assert.Contains(t3, result);
                Assert.Contains(t4, result);
            }
        }

        public class IntersectOfListsTest : LinqFunctionsTest
        {
            [Fact]
            public void TheTest()
            {
                // Arrange
                var t1 = new LinqModel(1, "1");
                var t2 = new LinqModel(2, "2");
                var t3 = new LinqModel(3, "3");
                var t4 = new LinqModel(4, "4");
                var t5 = new LinqModel(5, "5");
                var list1 = new List<LinqModel> { t1, t2, t3 };
                var list2 = new List<LinqModel> { t3, t4, t5 };

                // Act
                var result = uut.IntersectionOfLists(list1, list2);

                // Assert
                Assert.True(result.Count() == 1);
                Assert.Contains(t3, result);
            }
        }
    }
}
