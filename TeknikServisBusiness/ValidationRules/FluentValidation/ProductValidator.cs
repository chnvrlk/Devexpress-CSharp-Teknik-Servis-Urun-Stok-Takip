using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis;

namespace TeknikServisBusiness.ValidationRules.FluentValidation
{
    
    public class ProductValidator:AbstractValidator<Urunler>
    {
        public ProductValidator()
        {
            RuleFor(u => u.Ad).NotEmpty().WithMessage("Ürün ismi boş olamaz.");     
            RuleFor(u => u.KategoriId).NotEmpty();     
            RuleFor(u => u.Marka).NotEmpty();     
            RuleFor(u => u.Stok).NotEmpty();     
            RuleFor(u => u.Alis).NotEmpty();     
            RuleFor(u => u.Satis).NotEmpty();     
            RuleFor(u => u.Durum).NotEmpty();
            RuleFor(u => u.Satis).GreaterThan(0);  
            RuleFor(u => u.Stok).GreaterThanOrEqualTo((short)0);             
        }
    }
}
