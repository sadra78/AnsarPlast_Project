using System.Collections.Generic;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;
using System.Linq;
using _0_Framework.Application;

namespace CommentManagement.Infrastructure.EFCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>, ICommentRepository
    {
        private readonly CommentContext _context;
        public CommentRepository(CommentContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var query = _context.Comments.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Email = x.Email,
                Website = x.Website,
                IsConfirmed = x.IsConfirmed,
                IsCanceld = x.IsCanceld,
                Message = x.Message,
                Name = x.Name,
                OwnerRecordId = x.OwnerRecordId,
                Type = x.Type,
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
