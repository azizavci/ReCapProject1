using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //buraya bir tablo ve DB ile tabloyu bağlayacak sınıfı göndermemiz ile bu tablo üzerinde 
    //tüm CRUD işlemlerini gerçekleştireceğiz. Tekrar tekrar yazmamıza gerek kalmadan
    
    //IEntityRepository ile bu sınıftaki metotlar implement edilir.
    //IEntityRepository ise bir entity sınıfı ister
    //hangi tabloyu gönderirsen onun IEntityRepository si olur
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity> 
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using içerisinde yazdığımız veriler anında garbage collector ü çağırır
            //context nesnesi bellek maliyeti açısından fazla maliyetlidir 
            //o yüzden işimiz biter bitmez silmek isteriz
            //performans açısından artırmış oluruz.belleği hızlıca temizler

            //IDispossable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                //sadece bir ürün döndürür
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
