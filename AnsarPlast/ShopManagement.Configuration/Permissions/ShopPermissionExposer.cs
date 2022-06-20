using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "ProductCategories",new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.SearchProductCategories,"جست جو در دسته بندی محصولات"),
                        new PermissionDto(AdminPermissions.ListProductCategories,"لیست دسته بندی محصولات"),
                        new PermissionDto(AdminPermissions.CreateProductCategory,"ایجاد دسته بندی محصولات"),
                        new PermissionDto(AdminPermissions.EditProductCategory,"ویرایش دسته بندی محصولات"),
                    }
                },
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListProducts,"لیست محصولات"),
                        new PermissionDto(AdminPermissions.SearchProducts,"جستجو محصولات"),
                        new PermissionDto(AdminPermissions.CreateProduct,"ایجاد محصول"),
                        new PermissionDto(AdminPermissions.EditProduct,"ویرایش محصولات"),
                    }
                },

                {
                    "Slider", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListSlider,"لیست اسلایدر"),
                        new PermissionDto(AdminPermissions.SearchSlider,"جستجو اسلایدر"),
                        new PermissionDto(AdminPermissions.CreateSlider,"ایجاد اسلایدر"),
                        new PermissionDto(AdminPermissions.EditSlider,"ویرایش اسلایدر"),
                        new PermissionDto(AdminPermissions.DeleteSlider,"حذف اسلایدر"),
                    }
                },
                {
                    "ProductPicture", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListProductPicture,"لیست عکس محصولات"),
                        new PermissionDto(AdminPermissions.SearchProductPicture,"جستجو عکس محصولات"),
                        new PermissionDto(AdminPermissions.CreateProductPicture,"ایجاد عکس محصول"),
                        new PermissionDto(AdminPermissions.EditProductPicture,"ویرایش عکس محصول"),
                        new PermissionDto(AdminPermissions.DeleteProductPicture,"حذف عکس محصول"),
                    }
                },
                {
                    "Orders", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListOrder,"لیست سفارشات"),
                        new PermissionDto(AdminPermissions.SearchOrder,"جستجو در سفارشات"),
                        new PermissionDto(AdminPermissions.ItemOrder,"مشاهده لیست ریز لیست"),
                        new PermissionDto(AdminPermissions.CancelOrder,"لفو سفارش"),
                        new PermissionDto(AdminPermissions.SubmitOrder,"تایید سفارش"),

                    }
                },
                {
                    "Banners", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListBanner,"لیست بنر"),
                        new PermissionDto(AdminPermissions.SearchBanner,"جستجو بنر"),
                        new PermissionDto(AdminPermissions.CreateBanner,"ایجاد بنر"),
                        new PermissionDto(AdminPermissions.EditBanner,"ویرایش بنر"),
                        new PermissionDto(AdminPermissions.DeleteBanner,"حذف بنر"),
                    }
                },
                {
                    "OfferBanners", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListOfferBanner,"لیست بنر تخفیف"),
                        new PermissionDto(AdminPermissions.SearchOfferBanner,"جستجو بنر تخفیف"),
                        new PermissionDto(AdminPermissions.CreateOfferBanner,"ایجاد بنر تخفیف"),
                        new PermissionDto(AdminPermissions.EditOfferBanner,"ویرایش بنر تخفیف"),
                        new PermissionDto(AdminPermissions.DeleteOfferBanner,"حذف بنر تخفیف"),
                    }
                },
                {
                    "ProductFeatures", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListProductFeatures,"لیست جزئیات محصول"),
                        new PermissionDto(AdminPermissions.CreateProductFeatures,"ایجاد جزئیات محصول"),
                        new PermissionDto(AdminPermissions.EditProductFeatures,"ویرایش جزئیات محصول"),
                        new PermissionDto(AdminPermissions.DeleteProductFeatures,"حذف جزئیات محصول"),
                    }
                },
            };
        }
    }
}
