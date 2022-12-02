using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
  public interface IAppUserDal :IGenericDal<AppUser>
    {
        string GetSelectedUserName(string emailAddress);

    }
}
