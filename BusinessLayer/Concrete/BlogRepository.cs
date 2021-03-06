using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogRepository
    {
        Repository<Blog> blogRepository = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return blogRepository.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return blogRepository.List(x => x.BlogID == id);
        }
    }
}
