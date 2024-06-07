using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository iAccountService;

        public AccountService()
        {
            iAccountService = new AccountRepository();
        }

        public AccountMember GetAccountById(string id)
        {
           return iAccountService.GetAccountById(id);
        }
    }
}
