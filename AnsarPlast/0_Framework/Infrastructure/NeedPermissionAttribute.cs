using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Infrastructure
{
    public class NeedPermissionAttribute : Attribute
    {
        public NeedPermissionAttribute(int permission)
        {
            Permission = permission;
        }

        public int Permission { get; set; }
    }
}
