using System.Collections.Generic;
using WebAppArticulos.Models;

namespace WebAppArticulos.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> FindAllCategories();
        Categoria FindById(long id);
        void Save(Categoria categoria);
        void DeleteCategoria(Categoria categoria);
    }
}
