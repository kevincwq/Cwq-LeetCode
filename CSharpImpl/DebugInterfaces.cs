using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// This is the custom function interface.
    /// You should not implement it, or speculate about its implementation
    /// </summary>
    public interface CustomFunction
    {
        // Returns f(x, y) for any given positive integers x and y.
        // Note that f(x, y) is increasing with respect to both x and y.
        // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
        int f(int x, int y);
    }

    public interface VersionControl
    {
        bool IsBadVersion(int version);
    }

    public interface NestedInteger
    {
        /// <summary>
        /// true if this NestedInteger holds a single integer, rather than a nested list
        /// </summary>
        /// <returns></returns>
        bool IsInteger();

        /// <summary>
        /// the single integer that this NestedInteger holds, if it holds a single integer
        /// Return null if this NestedInteger holds a nested list
        /// </summary>
        int GetInteger();

        /// <summary>
        /// the nested list that this NestedInteger holds, if it holds a nested list
        /// Return null if this NestedInteger holds a single integer
        /// </summary>
        IList<NestedInteger> GetList();
    }

    public interface GuessGame
    {
        int guess(int num);
    }

    public interface SolBase
    {
        int Rand7();
    }

    public interface Master
    {
        int Guess(string word);
    }

    public interface MountainArray
    {
        int Get(int index);
        int Length();
    }
}
