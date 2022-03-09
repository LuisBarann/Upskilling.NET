using System.Collections.Generic;
using System.Linq;
using WebAppArticulos.Models;

namespace WebAppArticulos.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository 
    {
        public CategoriaRepository(ArticuloContext repositoryContext) : base(repositoryContext)
        {

        }

        public void DeleteCategoria(Categoria categoria)
        {
            if (categoria == null)
                return;
            Delete(categoria);
            SaveChanges();
        }

        public IEnumerable<Categoria> FindAllCategories()
        {
            return FindAll().ToList();
        }

        public Categoria FindById(long id)
        {
            return FindByCondition(cat => cat.CategoriaID == id).FirstOrDefault();
        }

        public void Save(Categoria categoria)
        {
            if (categoria.CategoriaID == 0)
                Create(categoria);
            else
                Update(categoria);
            //guardar los cambios
            SaveChanges();
        }
    }
}
