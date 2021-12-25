using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace InventoryManagement.Application.Contract.Inventory
{
    public class IncreaseInventory 
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long InventoryId { get; set; }

        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long Count { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
    }
}
