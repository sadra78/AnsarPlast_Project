using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class DiscountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "CustomerDiscount", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListCustomerDiscount,"لیست تخفبف مشتریان"),
                        new PermissionDto(AdminPermissions.SearchCustomerDiscount,"جستجو در تخفبف مشتریان"),
                        new PermissionDto(AdminPermissions.DefineCustomerDiscount,"اضافه کردن تخفبف مشتری"),
                        new PermissionDto(AdminPermissions.EditCustomerDiscount,"ویرایش تخفبف مشتری"),
                    }
                },
                {
                    "ColleagueDiscount", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListColleagueDiscount,"لیست تخفبف همکاران"),
                        new PermissionDto(AdminPermissions.SearchColleagueDiscount,"جستجو در تخفبف همکاران"),
                        new PermissionDto(AdminPermissions.DefineColleagueDiscount,"اضافه کردن تخفبف همکار"),
                        new PermissionDto(AdminPermissions.EditColleagueDiscount,"ویرایش تخفبف همکار"),
                    }
                },
                {
                    "DiscountCode", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListDiscountCode,"لیست کدهای تخفبف"),
                        new PermissionDto(AdminPermissions.SearchDiscountCode,"جستجو در کدهای تخفبف"),
                        new PermissionDto(AdminPermissions.DefineDiscountCode,"اضافه کردن کد تخفبف"),
                        new PermissionDto(AdminPermissions.EditDiscountCode,"ویرایش کد تخفبف"),
                    }
                },
            };
        }
    }
}
