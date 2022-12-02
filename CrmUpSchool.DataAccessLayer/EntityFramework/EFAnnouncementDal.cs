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
    public class EFAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public List<Announcement> ContainAAnnouncement()
        {
            using (var context = new Context())
            {
                //a ile başlayanlar
                var values = context.Announcements.Where(x => x.Title.Contains("a")).ToList();
                return values;

            }
        }
    }
}
