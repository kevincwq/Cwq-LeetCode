using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/friend-circles/
    /// 
    /// There are N students in a class. Some of them are friends, while some are not. Their friendship is transitive in nature. For example, if A is a direct friend of B, and B is a direct friend of C, then A is an indirect friend of C. And we defined a friend circle is a group of students who are direct or indirect friends.
    /// Given a N*N matrix M representing the friend relationship between students in the class. If M[i][j] = 1, then the i_th and j_th students are direct friends with each other, otherwise not. And you have to output the total number of friend circles among all the students.
    /// Example 1:
    /// Input: [[1,1,0], [1,1,0], [0,0,1]]
    /// Output: 2
    /// Explanation:The 0_th and 1_st students are direct friends, so they are in a friend circle. The 2_nd student himself is in a friend circle. So return 2.
    /// 
    /// 
    /// Example 2:
    /// Input: [[1,1,0], [1,1,1], [0,1,1]]
    /// Output: 1
    /// Explanation:The 0_th and 1_st students are direct friends, the 1_st and 2_nd students are direct friends, so the 0_th and 2_nd students are indirect friends. All of them are in the same friend circle, so return 1.
    /// 
    /// 
    /// Constraints:
    /// * 1 <= N <= 200
    /// * M[i][i] == 1
    /// * M[i][j] == M[j][i]
    /// 
    /// </summary>
    public class N0547_FriendCircles
    {
        public class Solution1 {
            public int FindCircleNum(int[][] M) {
                throw new NotImplementedException();
            }
        }
    }
}