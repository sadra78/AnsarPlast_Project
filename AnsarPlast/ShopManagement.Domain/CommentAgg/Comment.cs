using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Domain.CommentAgg
{
    public class Comment : EntityBase
    {

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public long ProductId { get; private set; }

        public bool IsConfirmed { get; private set; }
        public bool IsCanceld { get; private set; }
        public Product Product { get; private set; }

        public Comment(string name, string email, string message, long productId)
        {
            Name = name;
            Email = email;
            Message = message;
            ProductId = productId;
        }

        public void Confirmed()
        {
            IsConfirmed = true;
            IsCanceld = false;
        }

        public void Cancel()
        {
            IsCanceld = true;
            IsConfirmed = false;
        }
    }
}
