using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/design-twitter/
    /// 
    /// Design a simplified version of Twitter where users can post tweets, follow/unfollow another user and is able to see the 10 most recent tweets in the user's news feed. Your design should support the following methods:
    /// 
    /// 1. postTweet(userId, tweetId): Compose a new tweet.
    /// 2. getNewsFeed(userId): Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent.
    /// 3. follow(followerId, followeeId): Follower follows a followee.
    /// 4. unfollow(followerId, followeeId): Follower unfollows a followee.
    /// Example:
    /// 
    /// Twitter twitter = new Twitter(); // User 1 posts a new tweet (id = 5). twitter.postTweet(1, 5); // User 1's news feed should return a list with 1 tweet id -> [5]. twitter.getNewsFeed(1); // User 1 follows user 2. twitter.follow(1, 2); // User 2 posts a new tweet (id = 6). twitter.postTweet(2, 6); // User 1's news feed should return a list with 2 tweet ids -> [6, 5]. // Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5. twitter.getNewsFeed(1); // User 1 unfollows user 2. twitter.unfollow(1, 2); // User 1's news feed should return a list with 1 tweet id -> [5], // since user 1 is no longer following user 2. twitter.getNewsFeed(1);
    /// 
    /// </summary>
    public class N0355_DesignTwitter
    {
        public class Twitter {
        
            /** Initialize your data structure here. */
            public Twitter() {
                throw new NotImplementedException();
            }
            
            /** Compose a new tweet. */
            public void PostTweet(int userId, int tweetId) {
                throw new NotImplementedException();
            }
            
            /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
            public IList<int> GetNewsFeed(int userId) {
                throw new NotImplementedException();
            }
            
            /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
            public void Follow(int followerId, int followeeId) {
                throw new NotImplementedException();
            }
            
            /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
            public void Unfollow(int followerId, int followeeId) {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your Twitter object will be instantiated and called as such:
         * Twitter obj = new Twitter();
         * obj.PostTweet(userId,tweetId);
         * IList<int> param_2 = obj.GetNewsFeed(userId);
         * obj.Follow(followerId,followeeId);
         * obj.Unfollow(followerId,followeeId);
         */
    }
}