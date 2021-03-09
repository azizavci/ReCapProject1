using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //T yerine bizim entitylerimiz gelir
    //car,brand, color ...
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        //biz veriyi filtresiz de kullanabiliriz
        //filtresiz de bunu sağlamak için LINQ sorgularını kullanabileceğimiz bir Expression nesnesi kullandık
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //istenen ögenin detaylarına ulaşmak için kullanırız
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        
    }
}
