// 3. Implement a GenericRepository<T> class that implements IRepository<T> interface
// that will have common /CRUD/ operations so that it can work with any data source
// such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
// on T were it should be of reference type and can be of type Entity which has one
// property called Id. IRepository<T> should have following methods
//     1. void Add(T item)
//     2. void Remove(T item)
//     3. Void Save()
//     4. IEnumerable<T> GetAll()
//     5. T GetById(int id)

public interface IRepository <T> where T : class
    {
        void Add(T obj);
        void Remove(int id);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }



public class GenericRepository: IRepository<T>{
    IEnumerable<T> ie = new IEnumerable<T>();
    public void Add (T input){
        ie.Append(input);
    }
    public Remove(T input) {
        List<T> ielist = ie.ToList<T>();
        ielist.Remove(input);
        ie = (IEnumerable<int>)ielist;
    }
    public void Save(){
        ie.T.saveChange();
    }
    public IEnumerable<T> GetAll(){
        return ie;
    }
    public T GetById(int id){
        List<T> ielist = ie.ToList<T>();
        return ielist.Find(T => T.id=id);
    }
}
    