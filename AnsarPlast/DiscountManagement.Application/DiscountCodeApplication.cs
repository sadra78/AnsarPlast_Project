using System.Collections.Generic;
using _0_Framework.Application;
using DiscountManagement.Application.Contract.DiscountCode;
using DiscountManagement.Domain.DiscountCodeAgg;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DiscountManagement.Application
{
    public class DiscountCodeApplication : IDiscountCodeApplication
    {

        private readonly IDiscountCodeRepository _discountCodeRepository;

        public DiscountCodeApplication(IDiscountCodeRepository discountCodeRepository)
        {
            _discountCodeRepository = discountCodeRepository;
        }

        public OperationResult Define(DefineDiscountCode command)
        {
            var operation = new OperationResult();

            var startDate = command.StartDate.ToGeorgianDateTime();
            var endDate = command.EndDate.ToGeorgianDateTime();
            var discountCode = new DiscountCode(command.DiscountRate, command.CodeDiscount, startDate, endDate,
                command.Reason);
            _discountCodeRepository.Create(discountCode);
            _discountCodeRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditDiscountCode command)
        {
            var operation = new OperationResult();
            var discountCode = _discountCodeRepository.Get(command.Id);
            if (discountCode == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            if (_discountCodeRepository.Exists(x => x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var startDate = command.StartDate.ToGeorgianDateTime();
            var endDate = command.EndDate.ToGeorgianDateTime();
            discountCode.Edit(command.DiscountRate, command.CodeDiscount, startDate, endDate,
                command.Reason);
            _discountCodeRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult CheckCode(GetCode command)
        {
            var operation = new OperationResult();
            var discountCode = _discountCodeRepository.GetBy(command.CodeDiscount);
            if (discountCode == null)
            {
                return operation.Failed(ApplicationMessages.WrongDiscountCode);
            }
            
            return operation.Succedded();
        }

        public EditDiscountCode GetDetails(long id)
        {
            return _discountCodeRepository.GetDetails(id);
        }

        public EditDiscountCode GetDetailsBy(string code)
        {
            return _discountCodeRepository.GetBy(code);
        }

        public List<DiscountCodeViewModel> Search(DiscountCodeSearchModel searchModel)
        {
            return _discountCodeRepository.Search(searchModel);
        }
    }
}