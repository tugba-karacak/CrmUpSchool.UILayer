using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    class AnnouncementValidator: AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Personel Adı Boş Geçemezsiniz!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Personel Soyadını Boş Geçemezsiniz!");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz.");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz!");
        }
    }
}
