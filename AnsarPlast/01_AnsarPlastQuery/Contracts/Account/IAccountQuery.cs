using System.Collections.Generic;

namespace _01_AnsarPlastQuery.Contracts.Account
{
    public interface IAccountQuery
    {
        List<AccountQueryModel> GetAccounts();
    }
}