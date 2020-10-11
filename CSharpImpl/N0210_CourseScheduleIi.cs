using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/course-schedule-ii/
    /// 
    /// There are a total of n courses you have to take labelled from 0 to n - 1.
    /// Some courses may have prerequisites, for example, if prerequisites[i] = [a_i, b_i] this means you must take the course b_i before the course a_i.
    /// Given the total number of courses numCourses and a list of the prerequisite pairs, return the ordering of courses you should take to finish all courses.
    /// If there are many valid answers, return any of them. If it is impossible to finish all courses, return an empty array.
    /// 
    /// Example 1:
    /// Input: numCourses = 2, prerequisites = [[1,0]]
    /// Output: [0,1]
    /// Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So the correct course order is [0,1].
    /// 
    /// Example 2:
    /// Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
    /// Output: [0,2,1,3]
    /// Explanation: There are a total of 4 courses to take. To take course 3 you should have finished both courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0.
    /// So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].
    /// 
    /// Example 3:
    /// Input: numCourses = 1, prerequisites = []
    /// Output: [0]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= numCourses <= 2000
    /// * 0 <= prerequisites.length <= numCourses * (numCourses - 1)
    /// * prerequisites[i].length == 2
    /// * 0 <= a_i, b_i < numCourses
    /// * a_i != b_i
    /// * All the pairs [a_i, b_i] are distinct.
    /// 
    /// </summary>
    public class N0210_CourseScheduleIi
    {
        public class Solution1 {
            public int[] FindOrder(int numCourses, int[][] prerequisites) {
                throw new NotImplementedException();
            }
        }
    }
}