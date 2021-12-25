using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace AccountManagement.Infrastructure.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Account",new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.SearchAccount,"جست جو در کابران"),
                        new PermissionDto(AdminPermissions.ListAccount,"لیست کابران"),
                        new PermissionDto(AdminPermissions.CreateAccount,"ایجاد کاربر"),
                        new PermissionDto(AdminPermissions.EditAccount,"ویرایش کاربر"),
                        new PermissionDto(AdminPermissions.ChangePasswordAccount,"ویرایش رمز کاربر"),
                    }
                },
                {
                    "Role", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListRole,"لیست نقش ها"),
                        new PermissionDto(AdminPermissions.SearchRole,"جستجو در نقش ها"),
                        new PermissionDto(AdminPermissions.CreateRole,"ایجاد نقش"),
                        new PermissionDto(AdminPermissions.EditRole,"ویرایش نقش"),
                    }
                },
            };
        }
    }
}
