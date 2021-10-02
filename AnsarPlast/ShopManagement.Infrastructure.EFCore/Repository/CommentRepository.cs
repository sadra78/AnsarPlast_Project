using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Comment;
using ShopManagement.Domain.CommentAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>, ICommentRepository
    {
        private readonly ShopContext _context;
        public CommentRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var query = _context.Comments.Include(x => x.Product).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Email = x.Email,
                IsConfirmed = x.IsConfirmed,
                IsCanceld = x.IsCanceld,
                Message = x.Message,
                Name = x.Name,
                ProductId = x.ProductId,
                ProductName = x.Product.Name,
                CommentDate = x.CreationDate.ToFarsi(),
            });
            if (!string.IsNullOrWhiteSpace(searchModel.Message))
            {
                query = query.Where(x => x.Message.Contains(searchModel.Message));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
