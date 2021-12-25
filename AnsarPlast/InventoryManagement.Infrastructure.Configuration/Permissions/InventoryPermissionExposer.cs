using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "انبار", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListInventory,"لیست انبار"),
                        new PermissionDto(AdminPermissions.SearchInventory,"جستجو در انبار"),
                        new PermissionDto(AdminPermissions.CreateInventory,"اضافه کردن محصول به انبار"),
                        new PermissionDto(AdminPermissions.EditInventory,"ویرایش انبار"),
                        new PermissionDto(AdminPermissions.IncreaseInventory,"افزارش موجودی"),
                        new PermissionDto(AdminPermissions.ReduceInventory,"کاهش موجودی"),
                        new PermissionDto(AdminPermissions.InventoryOperationLog,"مشاهده گردش انبار"),
                    }
                },
            };
        }
    }
}
