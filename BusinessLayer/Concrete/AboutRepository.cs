using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutRepository
    {
        Repository<About> aboutRepository = new Repository<About>();
        public List<About> GetAll()
        {
            return aboutRepository.List();
        }
    }
}
