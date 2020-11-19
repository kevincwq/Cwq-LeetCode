using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0048_RotateImage
    {
        static object[] TestCases =
        {
            new object[]{
                new int[][] {
                    new[] { 1 }
                },
                new int[][] {
                    new[] { 1 }
                }
            },
            new object[]{
                new int[][] {
                    new[] { 1, 2 },
                    new[] { 3, 4 }
                },
                new int[][] {
                    new[] { 3, 1 },
                    new[] { 4, 2 }
                }
            },
            new object[]{
                new int[][] {
                    new[] { 1, 2, 3 },
                    new[] { 4, 5, 6 },
                    new[] { 7, 8, 9 }
                },
                new int[][] {
                    new[] { 7, 4, 1 },
                    new[] { 8, 5, 2 },
                    new[] { 9, 6, 3 }
                }
            },
            new object[]{
                new int[][] {
                    new[] { 5, 1, 9, 11 },
                    new[] { 2, 4, 8, 10 },
                    new[] { 13, 3, 6, 7 },
                    new[] { 15, 14, 12, 16 }
                },
                new int[][] {
                    new[] { 15, 13, 2, 5 },
                    new[] { 14, 3, 4, 1 },
                    new[] { 12, 6, 8, 9 },
                    new[] { 16, 7, 10, 11 }
                }
            },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[][] input, int[][] expected)
        {
            var so = new N0048_RotateImage.Solution1();
            var clone = TestHelper.Clone(input);
            so.Rotate(clone);
            Assert.IsTrue(TestHelper.AreEqual(expected, clone));
        }
    }
}