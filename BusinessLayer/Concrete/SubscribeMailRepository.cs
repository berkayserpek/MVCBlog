using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailRepository
    {
        Repository<SubscribeMail> smRepo = new Repository<SubscribeMail>();
        public int Add(SubscribeMail subscribeMail)
        {
            //@gmail.com
            if(subscribeMail.Mail.Length<=10 || subscribeMail.Mail.Length >= 50)
            {
                return -1;
            }
            return smRepo.Insert(subscribeMail);
        }
    }
}
