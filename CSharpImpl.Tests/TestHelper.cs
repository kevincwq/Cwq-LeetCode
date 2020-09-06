using System.Linq;

namespace CSharpImpl.Tests
{
    class TestHelper
    {
        public static bool AreEqual<T>(T[][] A, T[][] B)
        {
            if (A == null && B == null)
                return true;
            if (A.Length != B.Length)
                return false;
            for (int i = 0; i < A.Length; i++)
            {
                if (!Enumerable.SequenceEqual(A[i], B[i]))
                    return false;
            }
            return true;
        }
    }
}