using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comment", new List<PermissionDto>
                    {
                        new PermissionDto(AdminPermissions.ListComment,"لیست کامنت ها"),
                        new PermissionDto(AdminPermissions.SearchComment,"جستجو در کامنت ها"),
                        new PermissionDto(AdminPermissions.CancelComment,"لغو کامنت"),
                        new PermissionDto(AdminPermissions.ConfirmComment,"نایید کامنت"),
                    }
                },
            };
        }
    }
}
