using System.Diagnostics;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/jump-game-ii/
    /// 
    /// Given an array of non-negative integers, you are initially positioned at the first index of the array.
    /// Each element in the array represents your maximum jump length at that position.
    /// Your goal is to reach the last index in the minimum number of jumps.
    /// 
    /// Example:
    /// Input: [2,3,1,1,4]
    /// Output: 2
    /// Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
    /// 
    /// Note:
    /// You can assume that you can always reach the last index.
    /// 
    /// Constraints:
    /// 1 <= nums.length <= 3 * 10^4
    /// 0 <= nums[i] <= 10^5
    /// </summary>
    public class N0045_JumpGameIi
    {
        public class Solution1
        {
            public int Jump(int[] nums)
            {
                int index = 0;
                int step = 0;

                while (index < nums.Length - 1)
                {
                    Debug.Write($"{index}->");
                    var maxJump = nums[index];
                    if (maxJump + index >= nums.Length - 1)
                    {
                        step++;
                        break;
                    }

                    int nextMax = 0, toJump = 0;
                    var toEnd = nums.Length - 1 - index;
                    for (int i = 1; i <= maxJump; i++)
                    {
                        var nextJump = nums[index + i] + i;
                        if (nextJump > nextMax)
                        {
                            nextMax = nextJump;
                            toJump = i;
                        }
                        if (nextJump >= toEnd)
                        {
                            break;
                        }
                    }

                    step++;
                    index += toJump;
                }
                Debug.WriteLine(nums.Length - 1);
                return step;
            }
        }
    }
}