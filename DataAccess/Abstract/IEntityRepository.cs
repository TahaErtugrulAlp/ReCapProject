using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Nesnelerin tutluduğu interface
    //generic constraint = generic kısıt demek.
    //class = referans tip olabilir demek.
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new()=new'lene bilir olabilir demek.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression veritabanında filtreleme işlemi için kullanılıyor. Daha önceden yazdığımız kodları tekrar etmememiz için Expression kullandık.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
