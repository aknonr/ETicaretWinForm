using Project.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericReporsitory.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();

        List<T> GetModifieds();

        //Modify Commands

        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item); //bu metot veriyi pasifize eder
        void DeleteRange(List<T> list);
        void Destroy(T item); // Bu metottumuz veriyi yok eder !!!!!
        void DestroyRange(List<T> list);

        //Linq Expressions

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);
        //Find
        T Find(int id);


        //Get Last Datas
        List<T> GetLastDatas(int number = 1);

        //Get First Datas
        List<T> GetFirstDatas(int number = 1);

        //Get Datas
        List<T> GetCountedDatas(int number = 1);
    }
}
