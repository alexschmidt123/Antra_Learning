using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorAndBalls.Repository
{
    public interface IRepository <T> where T : class
    {
        int Insert(T obj);
        int Update(T obj);
        int Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
