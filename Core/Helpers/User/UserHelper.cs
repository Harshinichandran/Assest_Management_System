using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;

namespace Core.Helpers.User
{
    public class UserHelper
    {
        private Users m_user = null;
        private IQueryable<Facility> m_facilityCollection = null;
        private IQueryable<Role> m_roleCollection = null;

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

        public IQueryable<Facility> FacilityCollection
        {
            get
            {
                return m_facilityCollection;
            }
            set
            {
                m_facilityCollection = value;
            }
        }

        public IQueryable<Role> RoleCollection
        {
            get
            {
                return m_roleCollection;
            }
            set
            {
                m_roleCollection = value;
            }
        }
    }
}
