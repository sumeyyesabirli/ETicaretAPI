using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty()
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ÜRÜN Adını Boş Bırakmayın. ")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz");

            RuleFor(p => p.Stock).NotEmpty()
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ÜRÜN Adını Boş Bırakmayın. ")

                    //Stoc sayısal bir değer olduğu içn ve büyüklük küçüklük şartları için .MaximumLength yerine .Must u kullanıyoruz 

                    .Must(s => s >= 0)
                        .WithMessage("Stok bilgisini adam gibi giriniz");

            RuleFor(p => p.Price)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
               .Must(s => s >= 0)
                   .WithMessage("Fiyat bilgisi negatif olamaz!");




        }
    }
}
