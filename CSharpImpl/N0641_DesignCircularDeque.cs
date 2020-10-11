using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/design-circular-deque/
    /// 
    /// Design your implementation of the circular double-ended queue (deque).
    /// Your implementation should support following operations:
    /// * MyCircularDeque(k): Constructor, set the size of the deque to be k.
    /// * insertFront(): Adds an item at the front of Deque. Return true if the operation is successful.
    /// * insertLast(): Adds an item at the rear of Deque. Return true if the operation is successful.
    /// * deleteFront(): Deletes an item from the front of Deque. Return true if the operation is successful.
    /// * deleteLast(): Deletes an item from the rear of Deque. Return true if the operation is successful.
    /// * getFront(): Gets the front item from the Deque. If the deque is empty, return -1.
    /// * getRear(): Gets the last item from Deque. If the deque is empty, return -1.
    /// * isEmpty(): Checks whether Deque is empty or not.
    /// * isFull(): Checks whether Deque is full or not.
    /// 
    /// Example:
    /// MyCircularDeque circularDeque = new MycircularDeque(3); // set the size to be 3 circularDeque.insertLast(1); // return true circularDeque.insertLast(2); // return true circularDeque.insertFront(3); // return true circularDeque.insertFront(4); // return false, the queue is full circularDeque.getRear(); // return 2 circularDeque.isFull(); // return true circularDeque.deleteLast(); // return true circularDeque.insertFront(4); // return true circularDeque.getFront(); // return 4
    /// 
    /// 
    /// Note:
    /// * All values will be in the range of [0, 1000].
    /// * The number of operations will be in the range of [1, 1000].
    /// * Please do not use the built-in Deque library.
    /// 
    /// </summary>
    public class N0641_DesignCircularDeque
    {
        public class MyCircularDeque {
        
            /** Initialize your data structure here. Set the size of the deque to be k. */
            public MyCircularDeque(int k) {
                throw new NotImplementedException();
            }
            
            /** Adds an item at the front of Deque. Return true if the operation is successful. */
            public bool InsertFront(int value) {
                throw new NotImplementedException();
            }
            
            /** Adds an item at the rear of Deque. Return true if the operation is successful. */
            public bool InsertLast(int value) {
                throw new NotImplementedException();
            }
            
            /** Deletes an item from the front of Deque. Return true if the operation is successful. */
            public bool DeleteFront() {
                throw new NotImplementedException();
            }
            
            /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
            public bool DeleteLast() {
                throw new NotImplementedException();
            }
            
            /** Get the front item from the deque. */
            public int GetFront() {
                throw new NotImplementedException();
            }
            
            /** Get the last item from the deque. */
            public int GetRear() {
                throw new NotImplementedException();
            }
            
            /** Checks whether the circular deque is empty or not. */
            public bool IsEmpty() {
                throw new NotImplementedException();
            }
            
            /** Checks whether the circular deque is full or not. */
            public bool IsFull() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your MyCircularDeque object will be instantiated and called as such:
         * MyCircularDeque obj = new MyCircularDeque(k);
         * bool param_1 = obj.InsertFront(value);
         * bool param_2 = obj.InsertLast(value);
         * bool param_3 = obj.DeleteFront();
         * bool param_4 = obj.DeleteLast();
         * int param_5 = obj.GetFront();
         * int param_6 = obj.GetRear();
         * bool param_7 = obj.IsEmpty();
         * bool param_8 = obj.IsFull();
         */
    }
}