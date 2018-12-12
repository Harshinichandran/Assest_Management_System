using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;
namespace Core.Helpers.User
{
    public class AccountHelper
    {
    public Account m_account;
    public Users m_user;
        public Account AccountDetails
        {
            get
            {
                return m_account;
            }
            set
            {
                m_account = value;
            }
        }

        public Users UserDetails
        {
            get
            {
                return m_user;
            }
            set
            {
                m_user = value;
            }
        }
    }
}
