using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using _01_AnsarPlastQuery.Contracts.Account;
using AccountManagement.Infrastructure.EFCore;

namespace _01_AnsarPlastQuery.Query
{
    public class AccountQuery : IAccountQuery
    {
        private readonly AccountContext _accountContext;

        public AccountQuery(AccountContext accountContext)
        {
            _accountContext = accountContext;
        }

        public List<AccountQueryModel> GetAccounts()
        {
            return null;
        }
    }
}