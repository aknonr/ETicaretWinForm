using Project.BLL.DesignPatterns.SingletonPattern;
using Project.BLL.GenericReporsitory.IntRep;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericReporsitory
{
    public abstract class BaseRepository<T>:IRepository<T> where T : BaseEntity
    {
        protected MyContext _db;

        public BaseRepository()
        {
            //SingletonPattern ile veritabanının Insertini al
            _db = DBTool.DBInstance;
        }
        void Save()
        {
            //Kaydet
            _db.SaveChanges();
        }

        //Business Logic
        public void Add(T item)
        {
            //T tipindeki itemi T ye ekle !! 
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list)
        {
            //List<T> tipinde ki list'i T'ye ekle
            _db.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {

            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {//pasife çekme
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            //listeyi pasife çekme
            foreach (T item in list) Delete(item);
        }

        public void Destroy(T item)
        {
            //Veriyi silme
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            //listi verisini silme
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            //arama
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            //şarta uyan ifadelerin ilkini verir 
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetCountedDatas(int number = 1)
        {
            return _db.Set<T>().Take(number).ToList();
        }

        public List<T> GetFirstDatas(int number = 1)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetLastDatas(int number = 1)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();

        }
        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }
        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp);
        }
        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _db.Set<T>().Select(exp);
        }
        public void Update(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;

            T originalData = Find(item.ID);

            //_db.Entry'deki Entry metodu Veritabanında bir modifikasyon icin giriş bildirir...
            _db.Entry(originalData).CurrentValues.SetValues(item);
            Save();

        }
        public void UpdateRange(List<T> list)
        {
            foreach (T item in list) Update(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
