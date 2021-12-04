using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider
{
    public interface IEntityProvider<T,ID>
    {
        public bool Add(T entity);
        public bool Remove(ID id);
        public T Get(ID id);
        public List<T> GetAll();
        public bool Update(T entity);
        public List<T> GetBooksInShelf(ID id);
    }
}
