
using _0_Framework.Infrastructure;
using _01_AnsarPlastQuery.Contracts;
using _01_AnsarPlastQuery.Contracts.Banner;
using _01_AnsarPlastQuery.Contracts.OfferBanner;
using _01_AnsarPlastQuery.Contracts.Order;
using _01_AnsarPlastQuery.Contracts.Product;
using _01_AnsarPlastQuery.Contracts.ProductCategory;
using _01_AnsarPlastQuery.Contracts.Slide;
using _01_AnsarPlastQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Application.Contracts.OfferBanner;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductFeatures;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Configuration.Permissions;
using ShopManagement.Domain.BannerAgg;
using ShopManagement.Domain.OfferBannerAgg;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductFeaturesAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Domain.Services;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using ShopManagement.Infrastructure.Inventory.ACL;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
            services.AddTransient<IProductPictureRepository, ProductPictureRepository>();

            services.AddTransient<IProductFeaturesApplication, ProductFeaturesApplication>();
            services.AddTransient<IProductFeaturesRepository, ProductFeaturesRepository>();

            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();

            services.AddTransient<IOrderApplication, OrderApplication>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddTransient<IBannerApplication, BannerApplication>();
            services.AddTransient<IBannerRepository, BannerRepository>();

            services.AddTransient<IOfferBannerApplication, OfferBannerApplication>();
            services.AddTransient<IOfferBannerRepository, OfferBannerRepository>();

            services.AddSingleton<ICartService, CartService>();

            services.AddTransient<ISlideQuery, SlideQuery>();
            services.AddTransient<IProductCategoryQuery, ProductCategoryQuery>();
            services.AddTransient<IProductQuery, ProductQuery>();
            services.AddTransient<IBannerQuery, BannerQuery>();
            services.AddTransient<IOfferBannerQuery, OfferBannerQuery>();
            services.AddTransient<IOrderQuery, OrderQuery>();

            services.AddTransient<IPermissionExposer, ShopPermissionExposer>();
            services.AddTransient<ICartCalculatorService, CartCalculatorService>();
            services.AddTransient<IShopInventoryACL, ShopInventoryACL>();




            services.AddDbContext<ShopContext>(x=>x.UseSqlServer(connectionString));
        }
    }
}
