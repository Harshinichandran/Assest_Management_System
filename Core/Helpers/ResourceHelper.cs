using Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public class ResourceHelper
    {
        private Resources m_resource = null;
        private IQueryable<Facility> m_facilityCollection = null;

        public Resources ResourceDetails
        {
            get
            {
                return m_resource;
            }
            set
            {
                m_resource = value;
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
    }
}
