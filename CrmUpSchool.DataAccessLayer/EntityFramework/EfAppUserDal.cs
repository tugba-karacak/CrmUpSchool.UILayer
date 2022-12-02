using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Concrete;
using CrmUpSchool.DataAccessLayer.Repository;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public string GetSelectedUserName(string emailAdress)
        {
            using (var context = new Context())
            {
                return context.Users.Where(x => x.Email == emailAdress).Select(x => x.Name + " " + x.Surname).FirstOrDefault();

            }
        }
    }
}