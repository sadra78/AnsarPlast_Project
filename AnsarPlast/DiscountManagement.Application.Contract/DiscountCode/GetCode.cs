using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace DiscountManagement.Application.Contract.DiscountCode
{
    public class GetCode
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CodeDiscount { get; set; }
    }
}