using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Yazar adını boş beçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soy adını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriteTitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi Yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla giriş yapmayın");
            
        }
    }
}
