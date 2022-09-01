using FluentValidation;
using Sanmark.Erp.Entities.Concrete;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class DonemValidator : AbstractValidator<Donem>
    {
        public DonemValidator()
        {
            RuleFor(d => d.SirketId).NotEmpty().WithName("Şirket");//.WithMessage("Ünvanı boş olamaz");
            RuleFor(d => d.Yil).NotEmpty().WithName("Yıl").Must(DonemKontrol).WithMessage("Dönem 2020 ile 2050 arasında olmalıdır.");
            RuleFor(d => d.Baslangic).NotEmpty().WithName("Dönem Başlangıç").GreaterThan(p => new DateTime(2019, 12, 31)).
                WithMessage("2020 yılı öncesi tarih girilemez");
            RuleFor(m => m.Bitis).NotEmpty().WithName("Dönem Bitiş");
            RuleFor(x => x).Must(x => x.Bitis == default(DateTime) || x.Baslangic == default(DateTime) || x.Bitis > x.Baslangic)
                .WithMessage("Bitiş Tarihi Başlangıç Tarihinden Önce Olamaz");
        }

        private bool DonemKontrol(short arg)
        {
            var durum = false;
            if ((arg >= 2020) && (arg <= 2050))
                durum = true;
            return durum;
        }
    }
}
