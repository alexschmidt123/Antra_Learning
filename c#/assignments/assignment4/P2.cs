// 2. Create a Generic List data structure MyList<T> that can store any data type.
// Implement the following methods.
//     1. void Add (T element)
//     2. T Remove (int index)
//     3. bool Contains (T element)
//     4. void Clear ()
//     5. void InsertAt (T element, int index)
//     6. void DeleteAt (int index)
//     7. T Find (int index)

public class List<T> where T : class
{
    List<T> mylist = new List<T>();
    public void Add(T input) {
        mylist.Add(input);
    }

    public T Remove(int id) {
        T temp = new T();
        temp = mylist(id);
        mylist.RemoveAt(id);
        return temp;
    }

    public Boolean Contain (T input) {
        return mylist.Contain(input);
    }

    public void Clear() {
        mylist.Clear();
    }

    public void InsertAt(T input, int id) {
        mylist.InsertRange(id, input);
    }

    public void  DeleteAt (int id) {
        mylist.RemoveAt(id);
    }

    public T Find (int id) {
        return mylist.Find(T => T.id=id);
    }
}