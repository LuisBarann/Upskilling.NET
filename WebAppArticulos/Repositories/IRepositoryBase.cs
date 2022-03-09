using System;
using System.Linq;
using System.Linq.Expressions;

namespace WebAppArticulos.Repositories
{
    public interface IRepositoryBase<T>
    {
        //listar todo
        IQueryable<T> FindAll();
        //metodo que nos busque por alguna condicion
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        //crear
        void Create(T entity);
        //actualizar
        void Update(T entity);
        //eliminar
        void Delete(T entity);
        //guarde los cambios
        void SaveChanges();
    }
}
