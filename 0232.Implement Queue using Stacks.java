import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import java.util.Stack;

class MyQueue {

    Stack<Integer> s1 = new Stack<Integer>();
    Stack<Integer> s2 = new Stack<Integer>();

    public MyQueue() {

    }
    
    public void push(int x) {
        s2.push(x);
    }
    
    public int pop() {
        if(s1.empty()){
            while(!s2.empty()){
                s1.push(s2.pop());
            }
        }

        return s1.pop();
    }
    
    public int peek() {
        if(s1.empty()){
            while(!s2.empty()){
                s1.push(s2.pop());
            }
        }
        return s1.peek();
    }
    
    public boolean empty() {
        if(s1.empty() && s2.empty()){
            return true;
        }
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.peek();
 * boolean param_4 = obj.empty();
 */
