using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountId)
        {
            var accountMember = new AccountMember();

            // Đây chỉ là một ví dụ, trong thực tế, bạn sẽ truy vấn dữ liệu từ cơ sở dữ liệu
            if (accountId.Equals("PS0001"))
            {
                accountMember.MemberId = accountId;
                accountMember.MemberPassword = "@1";
                accountMember.MemberRole = 1;
            }

            return accountMember;
        }
    }
}
