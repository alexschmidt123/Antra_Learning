// 1. Create a custom Stack class MyStack<T> that can be used with any data type which
// has following methods
//     1. int Count()
//     2. T Pop()
//     3. Void Push() 

public class MyStack<T> where T : class
{
    Stack<T> mystack =new Stack<T>();
    public int Count(){
        return mystack.Count();
    }
    public T Pop(){
        T temp = new T();
        temp = mystack.Top();
        mystack.Pop();
        return temp;
    }
    public void Push(T input){
        mystack.Push(input);
    }
}